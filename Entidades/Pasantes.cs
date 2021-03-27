﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Pasantes.Entidades
{
    public class Pasantes
    {
        [Key]
        public int id { get; set; }
        public string NombrePasante { get; set; }
        public string Institucion { get; set; }
        public int Matricula { get; set; }
        public string Habilidad { get; set; }
        public int TotalHoras { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        public string Clave { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
