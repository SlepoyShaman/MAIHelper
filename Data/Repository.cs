using maihelper.Models.DataModels;
using maihelper.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace maihelper.Data
{
    public class Repository : IRepository
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> GetByIdAsync<TEntity>(int Id) where TEntity : class, IWithId
        {
            var result = await GetAll<TEntity>().FirstOrDefaultAsync(p => p.Id == Id);

            if (result != null) return result;
            else throw new NullReferenceException();
        }
        
        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class
            => _context.Set<TEntity>().Select(p => p);
        public async Task<TEntity> RemoveByIDAsync<TEntity>(int Id) where TEntity : class, IWithId
        {
            TEntity element = await GetByIdAsync<TEntity>(Id);
            if (element != null)
            {
                _context.Set<TEntity>().Remove(element);
                await _context.SaveChangesAsync();
                return element;
            }
            else throw new NullReferenceException();
        }

        public async Task AddNewItemAsync<TEntity>(TEntity entity) where TEntity : class
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateWorkPageFlagAsync(Work work) 
        {
            work.IsOnPage = !work.IsOnPage;
            _context.Entry(work).Property(w => w.IsOnPage).IsModified = true;
            await _context.SaveChangesAsync();
        }
    }
}
