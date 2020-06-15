using System;
using System.Collections.Generic;
using System.Text;

namespace Sesion2.Modelos
{
    class Division:Suma
    {
        public int add(int x, int y)
        {
            return x / y;
        }

        public decimal add(decimal x, decimal y)
        {
            return x / y;
        }


        public void operacion(int tipoDato)
        {
            string caracter1;
            string caracter2;

            Console.WriteLine("Ingrese le valor 1");
            caracter1 = Console.ReadLine();
            Console.WriteLine("Ingrese le valor 2");
            caracter2 = Console.ReadLine();
            Console.WriteLine("tipo de dato seleccionado" + tipoDato);
            try
            {
                switch (tipoDato)
                {
                    case 1:
                        int caract1 = Convert.ToInt32(caracter1);
                        int caract2 = Convert.ToInt32(caracter2);
                        Console.WriteLine("Su resultado es" + add(caract1, caract2));
                        break;
                    case 2:
                        decimal operacion = Convert.ToDecimal(caracter1);
                        decimal operacion2 = Convert.ToDecimal(caracter2);
                        Console.WriteLine("Su resultado es" + add(operacion, operacion2));
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Ingrese los valores segun el tipo de dato seleccionado");

            }
        }


    }
}

