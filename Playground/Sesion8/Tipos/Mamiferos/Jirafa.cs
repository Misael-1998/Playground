using System;
using Playground.Sesion8.Habilidades;

namespace Playground.Sesion8.Tipos.Mamiferos
{
    public class Jirafa: Mamifero , ICaminador
    {
        public Jirafa? Pareja { get; set; }
        
        public Jirafa(string nombre) : base(nombre)
        {
        }

        public void EstirarCuello()
        {
            Console.WriteLine($"Estirando cuello de {Nombre}");
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
            Console.WriteLine($"{Nombre} esta comiendo hojas yumi");
        }
        

        public void Caminar()
        {
            Console.WriteLine($"{Nombre} esta caminado y es {nameof(Jirafa)}");
        }

    }
}