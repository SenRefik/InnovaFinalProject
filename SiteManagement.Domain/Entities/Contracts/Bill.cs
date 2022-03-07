using SiteManagement.Domain.Entities.Commons;

namespace SiteManagement.Domain.Entities.Contracts
{
    public class Bill : EntityBase
    {
        public int FlatId { get; set; }
        public int BillTypeId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal BillPrice { get; set; }

    }
}
