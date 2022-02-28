using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SiteManagement.Domain.Entities.Authentications;
using SiteManagement.Domain.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteManagement.Infrastructure.Contracts.Repositories
{
    public class ApplicationContext : IdentityDbContext<User, Role, int>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
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
