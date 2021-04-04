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
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Prioridad { get; set; }
        public string Asignado { get; set; }
        public string Estado { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime FechaFinal { get; set; } = DateTime.Now;
    }
}
