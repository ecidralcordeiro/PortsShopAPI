using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Models;

namespace PortsShop.Infra.Data.ModelsConfiguration;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x => x.Name).HasMaxLength(200).IsRequired(true);
        builder.Property(x => x.Description).IsRequired(true);
        builder.Property(x => x.Description).IsRequired(true);

        builder.HasOne(x => x.Category)
                 .WithOne()
                 .HasForeignKey<Category>(x => x.Id)
                 .IsRequired(true);

        builder.HasOne(x => x.Branch)
              .WithOne()
              .HasForeignKey<Branch>(x => x.Id)
              .IsRequired(true)
              .OnDelete(DeleteBehavior.NoAction);


        builder.HasOne(x => x.Store)
              .WithOne()
              .HasForeignKey<Store>(x => x.Id)
              .IsRequired(true)
              .OnDelete(DeleteBehavior.NoAction);

    }
}

