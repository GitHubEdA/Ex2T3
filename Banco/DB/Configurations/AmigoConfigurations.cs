using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.DB.Configurations
{
    public class AmigoConfigurations : IEntityTypeConfiguration<Amigo>
    {
        public void Configure(EntityTypeBuilder<Amigo> builder)
        {
            builder.ToTable("Amigo");
            builder.HasKey(o => o.IdAmigo);

            builder.HasOne(x => x.User).WithMany(x => x.Amigos)
                .HasForeignKey(o => o.IdUser);
        }
    }
}
