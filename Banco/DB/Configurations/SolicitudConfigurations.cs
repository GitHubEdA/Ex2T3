using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.DB.Configurations
{
    public class SolicitudConfigurations : IEntityTypeConfiguration<Solicitud>
    {
        public void Configure(EntityTypeBuilder<Solicitud> builder)
        {
            builder.ToTable("Solicitud");
            builder.HasKey(o => o.IdSolicitud);

            builder.HasOne(x => x.User).WithMany(x => x.Solicitudes)
                .HasForeignKey(o => o.IdUser);
        }
    }
}
