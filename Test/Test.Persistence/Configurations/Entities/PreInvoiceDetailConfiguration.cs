using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Domain;

namespace Test.Persistence.Configurations.Entities
{
    public class PreInvoiceDetailConfiguration : IEntityTypeConfiguration<PreInvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<PreInvoiceDetail> builder)
        {
            builder.Property(a => a.Count)
                   .IsRequired();
        }
    }
}
