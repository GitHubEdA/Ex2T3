using Microsoft.EntityFrameworkCore;
using System;
using WebApplication3.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DB.Configurations
{
    public class CuentaConfigurations : IEntityTypeConfiguration<Cuenta>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Cuenta> builder)
        {
            builder.ToTable("Cuenta");
            builder.HasKey(o =>o.IdCuenta);
        }
    }
}
