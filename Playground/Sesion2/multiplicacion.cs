﻿using System;
using System.Collections.Generic;
using System.Text;
using Playground.Sesion2;

namespace Sesion2.Modelos
{
    class Multiplicacion
    {
        //Campos privados
        private int _x;
        private int _y;
        public int add(int x, int y)
        {
            return x * y;
        }

        public decimal add(decimal x, decimal y)
        {
            return x * y;
        }

        public Multiplicacion(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int ObtenerValorActual() => _x * _y;

        public static int MultiplicacionXd(Multiplicacion multiA, int multiB)
        {
            int multi1 = multiA.ObtenerValorActual();
            int multi2 = multiB;
            Multiplicacion Multiplicacion = new Multiplicacion(multi1,multi2);
            return Multiplicacion.ObtenerValorActual();

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
