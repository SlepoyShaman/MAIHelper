using maihelper.Models.DataModels;
using maihelper.Models.Interfaces;

namespace maihelper.Data
{
    public interface IRepository
    {
        public Task<TEntity> GetByIdAsync<TEntity>(int Id) where TEntity : class, IWithId;
        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class;
        public Task<TEntity> RemoveByIDAsync<TEntity>(int Id) where TEntity : class, IWithId;
        public Task AddNewItemAsync<TEntity>(TEntity entity) where TEntity : class;
        public Task UpdateWorkPageFlagAsync(Work work);

    }
}
