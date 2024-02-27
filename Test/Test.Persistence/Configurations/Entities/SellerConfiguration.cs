using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Domain;

namespace Test.Persistence.Configurations.Entities
{
    public class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {


            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.LastName)
              .IsRequired()
              .HasMaxLength(50);
            for (int i = 1; i <= 10; i++)
            {
                Random rnd = new Random();
                int randomSalesLine = rnd.Next(1, 6);

                builder.HasData(
                    new Seller
                    {
                        Id = i,
                        FirstName = $"FirstName {i}",
                        LastName = $"LastName {i}",
                        CreateDate = DateTime.Now,
                        SalesLineId = randomSalesLine
                    }
                );
            }
        }
    }
}
