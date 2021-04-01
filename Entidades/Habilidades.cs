using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Pasantes.Entidades
{
    public class Habilidades
    {
        [Key]
        public int HabilidadId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [ForeignKey("HabilidadId")]
        public virtual List<HabilidadesDetalle> Detalle { get; set; }

        public Habilidades()
        {
            HabilidadId = 0;
            FechaCreacion = DateTime.Now.Date;
            Nombre = string.Empty;
            Descripcion = string.Empty;
        }
    }
}
