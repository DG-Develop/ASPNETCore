using System;

namespace ASPNETMVC.Models{
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get; set; }

        //La palabra virtual significa que pueden ser reescritas por el componente hijo
        public virtual string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre}, {Id}";
        }
    }
}