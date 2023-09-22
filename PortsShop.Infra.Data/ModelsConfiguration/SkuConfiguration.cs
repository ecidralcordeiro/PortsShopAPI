using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Infra.Data.ModelsConfiguration;

public class SkuConfiguration : IEntityTypeConfiguration<SKU>
{
    public void Configure(EntityTypeBuilder<SKU> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.IdPrice).IsRequired();
        builder.Property(x => x.IdStock).IsRequired();

        builder.HasOne(x => x.Stock)
                  .WithOne()
                  .HasForeignKey<Stock>(x => x.Id)
                  .IsRequired();

        builder.HasOne(x => x.Price)
                  .WithOne()
                  .HasForeignKey<Price>(x => x.Id)
                  .IsRequired();

    }
}