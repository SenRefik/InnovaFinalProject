using SiteManagement.Domain.Entities.Commons;

namespace SiteManagement.Domain.Entities.Contracts
{
    public class FlatOfUser : EntityBase
    {
        public int UserId { get; set; }
        public int FlatId { get; set; }
        public bool IsOwner { get; set; }
        public bool IsTenant { get; set; }
    }
}
