using Gestion_de_Pasantes.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Pasantes.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Pasantes> Pasantes { get; set; }
        public DbSet<Instituciones> Instituciones { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Habilidades> Habilidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/DatosUsuarios.Db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Permisos>().HasData(
                new Permisos() { PermisoID = 1, NombrePermiso = "Modifica", DescripcionPermiso = "Este permiso puede modificar datos" },
                new Permisos() { PermisoID = 2, NombrePermiso = "Elimina", DescripcionPermiso = "Este permiso puede eliminar datos" },
                new Permisos() { PermisoID = 3, NombrePermiso = "Agrega", DescripcionPermiso = "Este permiso puede agregar datos" }
            );
        }
    }
}
