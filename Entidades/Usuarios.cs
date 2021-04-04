using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Pasantes.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombre = string.Empty;
            Alias = string.Empty;
            Email = string.Empty;
            Clave = string.Empty;
            FechaIngreso = DateTime.Now;
            Rol = string.Empty;
            Activo = false;
        }
    }
}
