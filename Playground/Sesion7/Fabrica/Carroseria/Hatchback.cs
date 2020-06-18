using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.Sesion7.Fabrica.Carroseria
{
    class Hatchback : ICarroceria
    {
        public void Carroceria()
        {
            Console.WriteLine("Trasero mas largo");
        }
    }
}
