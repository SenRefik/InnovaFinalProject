using SiteManagement.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Domain.Entities.Contracts
{
    public class Bill : EntityBase
    {
        public int FlatId { get; set; }
        public int BillTypeId { get; set; }
        public int Month { get; set; }
        public decimal BillPrice { get; set; }

    }
}
