using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);
            entity.DateCreated = DateTime.UtcNow;
            entity.DateModified = DateTime.UtcNow;
            await context.SaveChangesAsync();
            return entity;
        }

         public async Task AddRangeAsync(List<T> entities)
        {
            await context.AddRangeAsync(entities);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
            }
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }

            return await context.Set<T>().FindAsync(id);
        }

        public async Task<int> GetCountAsync()
        {
            return await context.Set<T>().CountAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            entity.DateModified = DateTime.UtcNow;
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
