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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/datosUsuarios.Db");
        }
    }
}
