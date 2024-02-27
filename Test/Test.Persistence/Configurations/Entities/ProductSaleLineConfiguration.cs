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

            for (int i = 1; i <= 100; i++)
            {
                Random rnd = new Random();
                int randomSalesLine = rnd.Next(1, 6);

                builder.HasData(
                    new ProductSaleLine
                    {
                        ProductId = i,
                        SalesLineId = randomSalesLine,
                    }
                );
            }
        }
    }
}
