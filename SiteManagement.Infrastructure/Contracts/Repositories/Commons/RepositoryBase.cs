using Microsoft.EntityFrameworkCore;
using SiteManagement.Application.Contracts.Persistence.Repositories.Commons;
using SiteManagement.Domain.Entities.Commons;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiteManagement.Infrastructure.Contracts.Repositories.Commons
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        protected readonly AppDbContext _appContext;

        public RepositoryBase(AppDbContext appContext)
        {
            _appContext = appContext;
            
        }


        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            var entity = _appContext.Set<T>().AsNoTracking();
            return await entity.ToListAsync();
            //var entity = await _appContext.Set<T>().ToListAsync();
            //return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            _appContext.Set<T>().Add(entity);
            await _appContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> GetByIdAsync(int entityId)
        {
            var list = _appContext.Set<T>().AsNoTracking();
            return await list.FirstOrDefaultAsync(x => x.Id == entityId);
        }

        public async Task UpdateAsync(T entity)
        {
            _appContext.Entry(entity).State = EntityState.Modified;
            await _appContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(T entity)
        {
            _appContext.Set<T>().Remove(entity);
            await _appContext.SaveChangesAsync();
        }
    }
}