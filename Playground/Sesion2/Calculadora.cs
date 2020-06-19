using Playground.Extras;
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

            CustomConsole console = new CustomConsole();
            console.WriteLines("E", "EEE", "EEEE", "Eso fue todo amigos");
            Suma xd = new Suma(0, 1)
                .Add(1)
                .Add(2)
                .Add(5);
            console.Print(xd.ObtenerValorActual().ToString());
            Suma[] xd2 = {new Suma(1, 1), new Suma(2, 2), new Suma(3, 3)};
            Suma xd3 = xd2[0].Add(5);
            xd2[0] = xd3;
            console.Print(xd2[0].ObtenerValorActual().ToString());
        }
    }
}