using Sesion2.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sesion2.Views
{
    class Menu:SubMenu
    {
        public void menu()
        {
            SubMenu subMenu = new SubMenu();
            int sub;

            do
            {

                Console.WriteLine("\n**Calculadora**\n" +
                    "\n1--Enteros--\n" +
                    "\n2--Decimales--\n" +
                    "\n3--Cadenas--\n" +
                    "\n4--Decimales--\n"+
                    "\n5-Flotantes---\n");
                sub = Convert.ToInt32(Console.ReadLine());
                /* if (sub != 1 && sub != 2 && sub != 3 && sub != 4)
                 {
                     Console.WriteLine("Ingrese una opcion valida");
                 }
                 else
                 {

                 }
                */
                subMenu.menuSub(sub);
                Console.ReadLine();
            } while (sub != 5);
        }
    }
       
}
