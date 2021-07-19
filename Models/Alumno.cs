using System;
using System.Collections.Generic;

namespace ASPNETMVC.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluacion> Evaluaciones { get; set; }
        public string CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}