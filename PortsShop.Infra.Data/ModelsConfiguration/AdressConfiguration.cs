using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Models;

namespace PortsShop.Infra.Data.ModelsConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

            builder.Property(a => a.Country)
                .HasMaxLength(100) 
                .IsRequired();

            builder.Property(a => a.State)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(a => a.City)
                .HasMaxLength(100) 
                .IsRequired();

            builder.Property(a => a.Region)
                .HasMaxLength(100) 
                .IsRequired();

            builder.Property(a => a.PostalCode)
                .HasMaxLength(20) 
                .IsRequired();

            builder.Property(a => a.Street)
                .HasMaxLength(255) 
                .IsRequired();
        }
    }

}
