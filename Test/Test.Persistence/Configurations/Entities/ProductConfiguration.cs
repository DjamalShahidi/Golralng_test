using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Domain;

namespace Test.Persistence.Configurations.Entities
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Title)
                   .IsRequired()
                   .HasMaxLength(50);

            for (int i = 1; i <= 100; i++)
            {
                builder.HasData(
                    new Product
                    {
                        Id = i,
                        Title = $"Product {i}",
                        CreateDate = DateTime.Now,
                    }
                );
            }
        }
    }
}
