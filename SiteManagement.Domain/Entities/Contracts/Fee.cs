using SiteManagement.Domain.Entities.Commons;

namespace SiteManagement.Domain.Entities.Contracts
{
    public class Fee : EntityBase
    {
        public int FlatId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal FeePrice { get; set; }
    }
}
