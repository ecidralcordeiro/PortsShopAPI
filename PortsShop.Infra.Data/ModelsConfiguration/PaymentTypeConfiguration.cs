using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Infra.Data.ModelsConfiguration;

public class PaymentTypeConfiguration : IEntityTypeConfiguration<PaymentType>
{
    public void Configure(EntityTypeBuilder<PaymentType> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        builder.Property(x => x.Number).IsRequired(true);
        builder.Property(x => x.Expiration).IsRequired(true);
        builder.Property(x => x.SecurityCode).IsRequired(true);

    }
}

