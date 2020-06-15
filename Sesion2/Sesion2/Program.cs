using Sesion2.Controllers;
using Sesion2.Modelos;
using Sesion2.Views;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Sesion2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu men = new Menu();

            men.menu();
        }
    }
}