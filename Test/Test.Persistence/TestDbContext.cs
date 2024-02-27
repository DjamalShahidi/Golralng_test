using Microsoft.EntityFrameworkCore;
using Test.Domain;
using Test.Domain.Common;

namespace Test.Persistence
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TestDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntity>())
            {

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreateDate = DateTime.UtcNow;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<PreInvoiceDetail> PreInvoiceDetails { get; set; }
        public DbSet<PreInvoiceHeader> PreInvoiceHeaders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSaleLine> ProductSaleLines { get; set; }
        public DbSet<SalesLine> SalesLines { get; set; }
        public DbSet<Seller> Sellers { get; set; }
    }

}
