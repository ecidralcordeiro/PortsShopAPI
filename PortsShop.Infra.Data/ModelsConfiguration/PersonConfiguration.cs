using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortsShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Infra.Data.ModelsConfiguration;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.CPF).HasMaxLength(11).IsRequired(false);
        builder.Property(x => x.Passport).HasMaxLength(30).IsRequired(false);
        builder.Property(x => x.Identity).HasMaxLength(30).IsRequired(false);
        builder.Property(x => x.Birthday).IsRequired();

    }
}

