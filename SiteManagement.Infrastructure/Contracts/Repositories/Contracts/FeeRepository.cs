using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Domain.Entities.Contracts;
using SiteManagement.Infrastructure.Contracts.Repositories.Commons;

namespace SiteManagement.Infrastructure.Contracts.Repositories.Contracts
{
    public class FeeRepository : RepositoryBase<Fee>, IFeeRepository
    {
        public FeeRepository(AppDbContext appContext) : base(appContext)
        {
        }
    }
}
