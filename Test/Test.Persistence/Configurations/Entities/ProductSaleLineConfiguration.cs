using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using Test.Domain;

namespace Test.Persistence.Configurations.Entities
{
    public class ProductSaleLineConfiguration : IEntityTypeConfiguration<ProductSaleLine>
    {
        public void Configure(EntityTypeBuilder<ProductSaleLine> builder)
        {
            builder.HasKey(a => new { a.ProductId, a.SalesLineId });

            builder.HasOne(a => a.Product)
                   .WithMany(a => a.ProductSaleLines)
                   .HasForeignKey(a => a.ProductId);

            builder.HasOne(a => a.SalesLine)
                   .WithMany(a => a.ProductSaleLines)
                   .HasForeignKey(a => a.SalesLineId);
        }
    }
}
