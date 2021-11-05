using Microsoft.EntityFrameworkCore;
using System;
using WebApplication3.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DB.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(o =>o.IdUsuario);
        }
    }
}
