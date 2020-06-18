using System;
using Playground.Sesion8.Habilidades;

namespace Playground.Sesion8.Tipos.Aves
{
    public class Pinguino : Ave, ICaminador, INadador
    {
        public Pinguino? Pareja {get; set;}
        
        public void Caminar()
        {
            Console.WriteLine($"{Name} Gorditos y bonitos muchachos estamos caminando {nameof(Pinguino)}");
        }

        public void Nadar()
        {
            Console.WriteLine($"{Name} vamos a nadar xd");
        }

        public Pinguino(string name) : base(name)
        {
        }

        public override void Aparearce()
        {
            if (Pareja == null)
            {
                Console.WriteLine($"{Name} ya valio xd");
            }
            if (Pareja.Genero == Genero)
            {
                Console.WriteLine($"{Name} ya la hizo");
            }
            
            Console.WriteLine($"{Name}Es hora del delicioso");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Name} esta comiendo un gansito xd");
        }

        public override void Dormir()
        {
            Console.WriteLine($"{Name} esta dormido zzzzzzzzzzzzzzz");
        }
    }
}