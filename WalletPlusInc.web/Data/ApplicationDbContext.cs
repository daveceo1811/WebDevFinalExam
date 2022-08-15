using Microsoft.EntityFrameworkCore;
using WalletPlusInc.web.Data.Entities;
using WalletPlusInc.web.Data.MappingConfiguration;

namespace WalletPlusInc.web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomerConfiguration.Build(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
