using Microsoft.EntityFrameworkCore;
using SiteManagement.Application.Contracts.Persistence.Repositories.Commons;
using SiteManagement.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Infrastructure.Contracts.Repositories.Commons
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        protected readonly ApplicationContext _appContext;

        public RepositoryBase(ApplicationContext appContext)
        {
            _appContext = appContext;
            
        }


        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            var entity = await _appContext.Set<T>().ToListAsync();
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            _appContext.Set<T>().Add(entity);
            await _appContext.SaveChangesAsync();
            return entity;
        }
    }
}