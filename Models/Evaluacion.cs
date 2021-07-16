using System;

namespace ASPNETMVC.Models
{
    public class Evaluacion: ObjetoEscuelaBase
    {
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota} {Nombre}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}