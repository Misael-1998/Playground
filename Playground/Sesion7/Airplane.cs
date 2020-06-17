using System;

namespace Playground.Sesion7
{
    class Airplane : IFlyable
    {


        public void Fly()
        {
            Console.WriteLine("AAAAAAIUUUUUUUUUUU....");
        }

        public void Land()
        {
            Console.WriteLine("iiiiiiiiight!!!");
        }
    }
}
