using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Pasantes.Entidades
{
    public class Tareas
    {
        [Key]
        public int TareaId { get; set; }
        public string NombreTarea { get; set; }
        public string Descripcion { get; set; }
        public string Prioridad { get; set; }
        public string Asignado { get; set; }
        public string Institucion { get; set; }
        public string Progreso { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime FechaFinal { get; set; } = DateTime.Now;
    }
}
