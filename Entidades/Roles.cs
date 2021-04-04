using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Pasantes.Entidades
{
    public class Roles
    {
        [Key]
        public int RolId { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool esActivo { get; set; }
        [ForeignKey("RolID")]
        public virtual List<RolesDetalle> Detalle { get; set; }

        public Roles()
        {
            RolId = 0;
            Descripcion = string.Empty;
            Detalle = new List<RolesDetalle>();
            FechaCreacion = DateTime.Now;
            esActivo = false;
        }
    }
}
