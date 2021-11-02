using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data
{
    public class Context : DbContext
    {
        public Context()
            : base("CarCenter_ConnectionString")
        {

        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Estados_Mantenimiento> Estados_Mantenimientos { get; set; }
        public DbSet<Estados_Mecanicos> Estados_Mecanicos { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<Fotos> Fotos { get; set; }
        public DbSet<Mantenimientos> Mantenimientos { get; set; }
        public DbSet<Marcas> Marcas { get; set; }
        public DbSet<Mecanicos> Mecanicos { get; set; }
        public DbSet<Presupuesto_X_Mantenimiento> Presupuesto_X_Mantenimientos { get; set; }
        public DbSet<Repuestos> Repuestos { get; set; }
        public DbSet<Repuestos_X_Mantenimientos> Repuestos_X_Mantenimientos { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Servicios_X_Mantenimientos> Servicios_X_Mantenimientos { get; set; }
        public DbSet<Tipos_Documento> Tipos_Documentos { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }
                protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Mantenimientos>().HasRequired(m => m.Mecanicos).WithMany(mc => mc.Mantenimientos).HasForeignKey(c => new { c.Mec_Tipo_Documento, c.Mec_Documento });

            modelBuilder.Entity<Facturas>().HasRequired(m => m.Clientes).WithMany(mc => mc.Facturas).HasForeignKey(c => new { c.Cli_Tipo_Documento, c.Cli_Documento });

            modelBuilder.Entity<Vehiculos>().HasRequired(m => m.Clientes).WithMany(mc => mc.Vehiculos).HasForeignKey(c => new { c.Cli_Tipo_Documento, c.Cli_Documento });
        }

    }
}
