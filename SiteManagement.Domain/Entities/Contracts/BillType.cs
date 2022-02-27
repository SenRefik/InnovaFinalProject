using SiteManagement.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Domain.Entities.Contracts
{
    public class BillType : EntityBase
    {
        public string Name { get; set; }
    }
}
