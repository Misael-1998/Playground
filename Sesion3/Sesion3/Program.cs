using Sesion3.Modelo;
using System;

namespace Sesion3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Arma weapon = new Arma();
            Cadenas cadena = new Cadenas();
            int opcion;
            Console.WriteLine("\n--1--*Disparar un arma*\n"+
                "--2--*Capturar cadenas*\n");
            opcion = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (opcion)
                {
                    case 1:
                        weapon.disparar();
                        break;

                    case 2:
                        cadena.capturarCadena();
                        break;
                    default:
                        break;
                }
            } while (opcion !=2);
            
        }
    }
}
