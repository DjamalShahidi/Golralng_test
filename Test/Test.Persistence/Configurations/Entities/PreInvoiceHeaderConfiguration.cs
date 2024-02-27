using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using Test.Domain;

namespace Test.Persistence.Configurations.Entities
{
    public class PreInvoiceHeaderConfiguration : IEntityTypeConfiguration<PreInvoiceHeader>
    {
        public void Configure(EntityTypeBuilder<PreInvoiceHeader> builder)
        {
            builder.HasOne(a => a.SalesLine)
                   .WithMany(a => a.PreInvoiceHeaders)
                   .HasForeignKey(a => a.SalesLineId);

            builder.HasOne(a => a.Customer)
                   .WithMany(a => a.PreInvoiceHeaders)
                   .HasForeignKey(a => a.CustomerId);

            builder.HasOne(a => a.Seller)
                   .WithMany(a => a.PreInvoiceHeaders)
                   .HasForeignKey(a => a.SellerId);
        }
    }
}
