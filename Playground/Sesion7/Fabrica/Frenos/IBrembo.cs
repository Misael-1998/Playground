using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.Sesion7.Fabrica.Frenos
{
    interface IBrembo : IFrenos
    {
        public void frenar()
        {
            Console.WriteLine("frenar xd");
        }
    }
}
