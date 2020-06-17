using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.Sesion7
{
    class Misil : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("fiiiiiuuuu");
        }

        public void Land()
        {
            Console.WriteLine("bom");
        }


    }
}
