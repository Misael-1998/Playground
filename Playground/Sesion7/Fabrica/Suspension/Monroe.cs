using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Playground.Sesion7.Fabrica.Suspension
{
    class Monroe : ISuspension
    {
        public void Suspender()
        {
            Console.WriteLine("Ssupender brusco");
        }
    }
}
