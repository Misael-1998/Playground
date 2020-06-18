using System.Collections.Generic;
using Playground.Sesion8.Tipos;
using Playground.Sesion8.Tipos.Aves;
using Playground.Sesion8.Tipos.Mamiferos;

namespace Playground.Sesion8
{
    public static class Zoo
    {
        private static int cantidadDeAnimales { 
            get => Animales.Count;
        }
        
        public static List<Animal> Animales { get; set; } = new List<Animal>
        {
            new Jirafa("Jorge"),
            new Leon("Casimiro"),
            new Leon("YaNomiro"),
            new Jirafa("Yakuto"),
            new Pinguino("baltazar"),
            new Pato("Lucas")

        };

        public static void AlimentarAnimales()
        {
            foreach (Animal animal in Animales)
            {
                animal.Comer();
            }
            
            (Animales[1] as Leon)?.Rugir();
        }

        

    }
}