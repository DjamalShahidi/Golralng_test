using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Domain;

namespace Test.Persistence.Configurations.Entities
{
    public class SalesLineConfiguration : IEntityTypeConfiguration<SalesLine>
    {
        public void Configure(EntityTypeBuilder<SalesLine> builder)
        {
            builder.Property(a => a.Title)
                   .IsRequired()
                   .HasMaxLength(50);

            for (int i = 1; i <= 5; i++)
            {
                builder.HasData(
                    new SalesLine
                    {
                        Id = i,
                        Title = $"Line {i}"
                    }
                );
            }
        }
    }
}
