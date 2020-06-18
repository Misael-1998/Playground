using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.Sesion7.Fabrica.Frenos
{
    class Boschcs : IFrenos
    {
        public void Frenar()
        {
            Console.WriteLine("Frenar suave xd");
        }
            
    }
}
