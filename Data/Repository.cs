namespace maihelper.Data
{
    public class Repository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class
            => _context.Set<TEntity>().Select(p => p);

    }
}
