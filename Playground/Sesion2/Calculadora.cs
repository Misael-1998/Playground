﻿using Playground.Extras;
using Sesion2.Modelos;
using System;

namespace Playground.Sesion2
{
    class Calculadora
    {

        public void Calcular()
        {
            // sumando int
            Console.WriteLine($"Resultado de suma {new Suma().Add(5, 5)}");

            // sumando float
            Console.WriteLine($"Resultado de suma {new Suma().Add(5.5f, 4.5f)}");

            // sumando decimal
            Console.WriteLine($"Resultado de suma {new Suma().Add(5.0000001M, 4.9999999M)}");


            // sumando cadenas
            if (new Suma().TryAdd("0.999", "alv", out decimal res))
            {
                Console.WriteLine($"Resultado de suma {res}");
            }
            else
            {
                Console.WriteLine("Error al convertir alguno de los numeros");
            }
            if (new Suma().TryAdd("5.02", "15.98", out decimal res2))
            {
                Console.WriteLine($"Resultado de suma {res2}");
            }
            else
            {
                Console.WriteLine("Error al convertir alguno de los numeros");
            }

            // sumando enteros con metodo sobrecargado y parametrizado 
            int x = new Suma().Add(5, 2, 7, 9, 3, 1, 5, 3);
            Console.WriteLine($"El resultado es: {x}");

            new CustomConsole().WriteLines("E", "EEE", "EEEE", "Eso fue todo amigos");
        }

    }
}