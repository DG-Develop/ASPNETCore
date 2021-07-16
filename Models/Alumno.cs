using System;
using System.Collections.Generic;

namespace ASPNETMVC.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();
    }
}