using System;

namespace Playground.Sesion8.Tipos.Mamiferos
{
    public abstract class Mamifero : Animal
    {
        public int edad { get; set; } = 0;
        public string Nombre { get; set; }

        public Mamifero(string nombre): base(nombre)
        {
            Nombre = nombre;
        }

        public void Mamar()
        {
            Console.WriteLine($"glup glup glup {Nombre}");
        }

        public override void Dormir()
        {
            Console.WriteLine($"{Nombre}: ZZZZZZ");
        }
    }
}