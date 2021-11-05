using Microsoft.EntityFrameworkCore;
using System;
using WebApplication3.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DB.Configurations
{
    public class TransferenciaConfigurations : IEntityTypeConfiguration<Transferencia>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Transferencia> builder)
        {
            builder.ToTable("Transferencia");
            builder.HasKey(o =>o.IdTransferencia);

        }
    }
}
