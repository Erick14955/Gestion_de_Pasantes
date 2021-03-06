using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Pasantes.Entidades
{
    public class Instituciones
    {
        [Key]

        public int InstitucionId { get; set; }
        public string Nombre { get; set; }
        public string Region { get; set; }        
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha { get; set; }
        public string Telefono { get; set; }
        public string NumFax { get; set; }
        public bool Activo { get; set; }
        public string TipoInstitucion { get; set; }
    }
}
