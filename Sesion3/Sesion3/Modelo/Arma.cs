using System;
using System.Collections.Generic;
using System.Text;

namespace Sesion3.Modelo
{
    class Arma
    {
    public void disparar()
    {
            int opcion;
            Console.WriteLine("Toma un arma");
            Console.WriteLine("\n--1**Metralleta**--\n"+
                "\n--2 **Arco**--\n"+
                "\n--2 **Bazoca**--\n");
            opcion = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (opcion)
                {
                    case 1:
                        int disparos;
                        Console.WriteLine("Cunatas veces desea disparar");
                        disparos = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < disparos; i++)
                        {
                            Console.WriteLine("ratatata");
                            
                        }
                        break;
                    case 2:
                       
                        Console.WriteLine("Cunatas veces desea disparar");
                        disparos = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < disparos; i++)
                        {
                            Console.WriteLine("---->");
                            
                        }
                        
                        break;

                    default:
                        break;
                }
            } while (true);
    }
   }
}
