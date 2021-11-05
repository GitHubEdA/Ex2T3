using Microsoft.EntityFrameworkCore;
using System;
using WebApplication3.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DB.Configurations
{
    public class TransaccionConfigurations : IEntityTypeConfiguration<Transaccion>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Transaccion> builder)
        {
            builder.ToTable("Transaccion");
            builder.HasKey(o =>o.IdTransaccion);

            builder.HasOne(o => o.Cuenta)
                .WithMany()
                .HasForeignKey(o => o.IdCuenta);
        }
    }
}
