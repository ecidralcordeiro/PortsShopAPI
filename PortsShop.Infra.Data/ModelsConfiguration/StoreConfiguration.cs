using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortsShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PortsShop.Infra.Data.ModelsConfiguration;

public class StoreConfiguration : IEntityTypeConfiguration<Store>
{
    public void Configure(EntityTypeBuilder<Store> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x => x.CompanyName).HasMaxLength(50).IsRequired(false);
        builder.Property(x => x.FantasyName).HasMaxLength(50).IsRequired(false);
        builder.Property(x => x.CNPJ).HasMaxLength(14).IsRequired(false);

        builder.HasOne(x => x.Address)
                 .WithOne()
                 .HasForeignKey<Address>(x => x.Id)
                 .IsRequired(false)
                 .OnDelete(DeleteBehavior.NoAction);

    }
}

