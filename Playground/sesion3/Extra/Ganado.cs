using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.sesion3.Extra
{
    class Ganado
    {
        public Vacas? vaca { get; set; }
        public string Name { get; } = "";

        public Ganado(string name)
        {
            Name = name;
        }

       public bool Entrar() 
       {
            if (vaca == null)
            {
                Console.WriteLine("Siguiente ganado");
                return false;
            }
            if (vaca.Entrar())
            {
                int numeroVaca = vaca.ObtenerVaca();
                Console.WriteLine($"{Name}--muuu{numeroVaca}");
                return true;
            }
            else
            {
                Console.WriteLine("Ya no hay mas vacas");
                return false;
            }
       }

        public void VolverEntrar(Vacas ternero)
        {
            vaca = ternero;
        }
       
    }
}
