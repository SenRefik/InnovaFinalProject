using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SiteManagement.Domain.Entities.Authentications;
using SiteManagement.Domain.Entities.Contracts;

namespace SiteManagement.Infrastructure.Contracts.Repositories
{
    public class AppDbContext : IdentityDbContext<User, Role, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        #region Tables
        public DbSet<Flat> Flats { get; set; }
        public DbSet<User> AspNetUsers { get; set; }
        public DbSet<FlatOfUser> FlatsOfUsers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<BillType> BillTypes { get; set; }
        #endregion
    }
}
