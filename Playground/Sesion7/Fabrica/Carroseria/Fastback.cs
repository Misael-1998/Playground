using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.Sesion7.Fabrica.Carroseria
{
    class Fastback : ICarroceria
    {
        public void Carroceria()
        {
            Console.WriteLine("Techo inclinado");
        }
    }
}
