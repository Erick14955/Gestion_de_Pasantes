using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Pasantes.Entidades
{
    public class HabilidadesDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int PasanteId { get; set; }
        public int HabilidadId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Comentario { get; set; }

        public HabilidadesDetalle()
        {
            DetalleId = 0;
            PasanteId = 0;
            HabilidadId = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Comentario = string.Empty;
        }

        public HabilidadesDetalle(int DetalleId, int PasanteId, int HabilidadId, string Nombre, string Descripcion, string Comentario)
        {
            this.DetalleId = DetalleId;
            this.PasanteId = PasanteId;
            this.HabilidadId = HabilidadId;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Comentario = Comentario;
        }
    }
}
