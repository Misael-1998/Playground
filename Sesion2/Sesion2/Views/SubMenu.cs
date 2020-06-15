using Sesion2.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sesion2.Controllers
{
    class SubMenu
    {
        public void menuSub(int tipoDato)
        {
            Suma sum = new Suma();
            Resta res = new Resta();
            multiplicacion mult = new multiplicacion();
            Division div = new Division();
            char Option;
            do
            {
                Console.WriteLine("\n***Bienvendido***\n");
                Console.WriteLine("\n**Calculadora**\n" +
                    "\n1--Suma--\n" +
                    "\n2--Resta--\n" +
                    "\n3--Multiplicacion--\n" +
                    "\n4--Division--\n");
                Option = Console.ReadKey().KeyChar;
                Console.ReadKey();
                switch (Option)
                {
                    case '1':
                        sum.operacion(tipoDato);
                        Console.ReadKey();
                        break;
                    case '2':
                        res.operacion(tipoDato);
                        Console.ReadKey();
                        break;
                    case '3':
                        mult.operacion(tipoDato);
                        Console.ReadKey();
                        break;
                    case '4':
                        div.operacion(tipoDato);

                        break;
                    default:
                        Console.WriteLine("\nPor favor ingrese una opcion valida\n");
                        break;
                }
            } while (Option != 5);




        }

    }
    }

