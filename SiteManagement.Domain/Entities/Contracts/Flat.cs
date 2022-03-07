using SiteManagement.Domain.Entities.Commons;

namespace SiteManagement.Domain.Entities.Contracts
{
    public class Flat : EntityBase
    {
        public int BlockId { get; set; }
        public int Floor { get; set; }
        public bool IsFull { get; set; }
        public int DoorNumber { get; set; }
        public string Type { get; set; }
    }
}
