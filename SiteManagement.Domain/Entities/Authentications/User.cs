using Microsoft.AspNetCore.Identity;

namespace SiteManagement.Domain.Entities.Authentications
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IDNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string LicencePlate { get; set; }
    }
}
