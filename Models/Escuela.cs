using System;
using System.Collections.Generic;


namespace ASPNETMVC.Models
{
    public class Escuela: ObjetoEscuelaBase
    {
       
        public int AnioCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public string Direccion { get; set; }

        public TiposEscuela TipoEscuela { get; set; }

        public List<Curso> Cursos { get; set; }

        public Escuela()
        {
            
        }

        public Escuela(string nombre, int anio) => (Nombre, AnioCreacion) = (nombre, anio);

        public Escuela(
            string nombre,
            int anio,
            TiposEscuela tipo,
            string pais = "",
            string ciudad = ""
        ) => (Nombre, AnioCreacion, TipoEscuela, Pais, Ciudad) = (nombre, anio, tipo, pais, ciudad);

        public override string ToString() =>
        $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine}Pais: {Pais}, Ciudad: {Ciudad}";
        
    }
}