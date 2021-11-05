using Microsoft.EntityFrameworkCore;
using WebApplication3.Controllers;
using WebApplication3.DB.Configurations;
using WebApplication3.Models;

namespace WebApplication3.DB
{
    public class AppPruebaContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Transaccion> Transaccions { get; set; }
        public DbSet<Transferencia> Transferencias { get; set; }
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<Interbancaria> Interbancarias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3Q4MLVO\\MSQLSERVER ; Database=Banco; Trusted_Connection=True; MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfiguration(new CuentaConfigurations());
            modelBuilder.ApplyConfiguration(new TransaccionConfigurations());
            modelBuilder.ApplyConfiguration(new TransferenciaConfigurations());
            modelBuilder.ApplyConfiguration(new AmigoConfigurations());
            modelBuilder.ApplyConfiguration(new SolicitudConfigurations());
            modelBuilder.ApplyConfiguration(new InterbancariaConfigurations());
        }
    }
}
