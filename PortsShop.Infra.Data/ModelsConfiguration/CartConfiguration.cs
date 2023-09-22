using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Models;

namespace PortsShop.Infra.Data.ModelsConfiguration;
public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder
            .HasOne(x => x.User)
            .WithMany(x => x.Carts)
            .HasForeignKey(x => x.IdUser)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasOne(x => x.SKU)
            .WithMany(x => x.Carts)
            .HasForeignKey(x => x.IdSku)
            .OnDelete(DeleteBehavior.NoAction);

    }
}
