using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.DB.Configurations
{
    public class InterbancariaConfigurations : IEntityTypeConfiguration<Interbancaria>
    {
        public void Configure(EntityTypeBuilder<Interbancaria> builder)
        {
            builder.ToTable("Interbancaria");
            builder.HasKey(o => o.IdInterbancaria);

            builder.HasOne(o => o.Cuenta)
                .WithMany()
                .HasForeignKey(o => o.IdCuentaInicio);
        }
    }
}
