using System;
using Playground.Sesion8.Habilidades;

namespace Playground.Sesion8.Tipos.Mamiferos
{
    public class Leon: Mamifero, ICaminador
    {
        public  Leon? Pareja { get; set; }
        
        public Leon(string nombre) : base(nombre)
        {
        }

        public void Rugir()
        {
            Console.WriteLine($"{Nombre}Roooooar!!!");
        }

        public override void Aparearce()
        {
            
            if (Pareja == null)
            {
                Console.WriteLine($"{Nombre} esta triste y solo");
                return;
            }

            if (Pareja.Genero == Genero)
            {
                Console.WriteLine($"{Nombre} dijo: No homo");
            }
            
            Console.WriteLine($"{Nombre} lo esta disfrutando :v");
        }

        public override void Comer()
        {
            Console.WriteLine($"{Nombre} esta comiendo carner yumi");
        }

        public void Caminar()
        {
            Console.WriteLine($"{Nombre} esta caminado y es {nameof(Leon)}");
        }
    }
}