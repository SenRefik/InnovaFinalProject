using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Domain.Entities.Contracts;
using SiteManagement.Infrastructure.Contracts.Repositories.Commons;

namespace SiteManagement.Infrastructure.Contracts.Repositories.Contracts
{
    public class FlatOfUserRepository : RepositoryBase<FlatOfUser>, IFlatOfUserRepository
    {
        public FlatOfUserRepository(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
