using System;
using Playground.Sesion8.Habilidades;

namespace Playground.Sesion8.Tipos.Aves
{
    public class Pato: Ave, ICaminador, INadador, IVolador
    {
        public Pato? Pareja { get; set; }

        public void Caminar()
        {
            Console.WriteLine($"{Name}esta caminando y es{nameof(Pato)}");
        }

        public void Nadar()
        {
            Console.WriteLine($"{Name} estoy nadando que chingon soy xd");
        }

        public void Volar()
        {
            Console.WriteLine($"{Name}Yo se qu epuedo volar");
        }

        public Pato(string name) : base(name)
        {
        }

        public override void Aparearce()
        {
            if (Pareja == null)
            {
                Console.WriteLine($"{Name} esta triste y solo x2");
                return;
            }
            if (Pareja.Genero == Genero)
            {
                Console.WriteLine($"{Name} No homo");
            }
            Console.WriteLine($"{Name}acto del delicioso");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Name} esta comiendo semillas iko");
        }

        public override void Dormir()
        {
            Console.WriteLine($"{Name} estoy dormido no molestar zzzzzzzz");
        }
    }
}