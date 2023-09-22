using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Infra.Data.ModelsConfiguration;

public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
{
    public void Configure(EntityTypeBuilder<Purchase> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x => x.TotalPrice).IsRequired(true);
        builder.Property(x => x.DATE).IsRequired(true);
        builder.Property(x => x.IdSKU).IsRequired(true);
        builder.Property(x => x.IdUser).IsRequired(true);

        builder
          .HasOne(x => x.User)
          .WithMany(x => x.Purchases)
          .HasForeignKey(x => x.IdUser)
          .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(x => x.SKU)
            .WithMany(x => x.Purchases)
            .HasForeignKey(x => x.IdSKU)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.PaymentType)
                  .WithOne()
                  .HasForeignKey<Purchase>(x => x.Id)
                  .IsRequired(false);
    }
}