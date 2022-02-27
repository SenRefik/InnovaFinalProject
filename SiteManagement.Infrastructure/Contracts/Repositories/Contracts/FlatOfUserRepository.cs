using SiteManagement.Application.Contracts.Persistence.Repositories.Contracts;
using SiteManagement.Domain.Entities.Contracts;
using SiteManagement.Infrastructure.Contracts.Repositories.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Infrastructure.Contracts.Repositories.Contracts
{
    public class FlatOfUserRepository : RepositoryBase<FlatOfUser>, IFlatOfUserRepository
    {
        public FlatOfUserRepository(ApplicationContext appContext) : base(appContext)
        {
        }
    }
}
