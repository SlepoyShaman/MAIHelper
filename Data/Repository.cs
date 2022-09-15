using maihelper.Models;

namespace maihelper.Data
{
    public class Repository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public TEntity GetById<TEntity>(int Id) where TEntity : class, IWithId
            => _context.Set<TEntity>().FirstOrDefault(p => p.Id == Id);
        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class
            => _context.Set<TEntity>().Select(p => p);
        public void RemoveByID<TEntity>(int Id) where TEntity : class, IWithId
        {
            TEntity element = GetById<TEntity>(Id);
            if(element != null)
            {
                _context.Set<TEntity>().Remove(element);
            }
        }

    }
}
