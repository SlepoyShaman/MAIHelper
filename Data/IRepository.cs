using maihelper.Models.Interfaces;

namespace maihelper.Data
{
    public interface IRepository
    {
        public TEntity GetById<TEntity>(int Id) where TEntity : class, IWithId;
        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class;
        public void RemoveByID<TEntity>(int Id) where TEntity : class, IWithId;
        public void AddNewItem<TEntity>(TEntity entity) where TEntity : class;
        public void Update();

    }
}
