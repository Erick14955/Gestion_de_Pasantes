using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Pasantes.Entidades
{
    public class Pasantes
    {
        [Key]
        public int PasanteId { get; set; }
        public string Nombre { get; set; }
        public int InstitucionId { get; set; }
        public int Matricula { get; set; }
        public int HorasARealizar { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        [ForeignKey("PasanteId")]
        public virtual List<HabilidadesDetalle> Detalle { get; set; }

        public Pasantes()
        {
            PasanteId = 0;
            Nombre = string.Empty;
            InstitucionId = 0;
            Matricula = 0;
            HorasARealizar = 0;
            Email = string.Empty;
            Telefono = string.Empty;
            Activo = false;
            FechaCreacion = DateTime.Now.Date;
            Detalle = new List<HabilidadesDetalle>();
        }

    }
}
