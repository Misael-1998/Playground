using System;

namespace Playground.Sesion7
{
    class Duck : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("cuaq cuaq xqak");
        }

        public void Land()
        {
            Console.WriteLine("brupcs");
        }
    }
}
