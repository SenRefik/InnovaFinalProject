namespace SiteManagement.Application.Settings
{
    public class JwtSettings
    {
        public string Issuer { get; set; }
        public string Secret { get; set; }
        public int ExpirationDays { get; set; }
    }
}
