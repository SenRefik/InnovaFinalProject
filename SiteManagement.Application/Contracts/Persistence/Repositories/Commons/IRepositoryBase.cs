using SiteManagement.Domain.Entities.Commons;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SiteManagement.Application.Contracts.Persistence.Repositories.Commons
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        #region C|create


        Task<T> AddAsync(T entity);



        #endregion

        #region R|read


        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int entityId);



        #endregion

        #region U|Update

        Task UpdateAsync(T entity);


        #endregion

        #region D|delete

        Task RemoveAsync(T entity);


        #endregion

    }
}
