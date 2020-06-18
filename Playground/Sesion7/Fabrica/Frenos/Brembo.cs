using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.Sesion7.Fabrica.Frenos
{
    class Brembo : IFrenos
    {
        public void Frenar()
        {
            Console.WriteLine("Frenar super suave");
        }
    }
}
