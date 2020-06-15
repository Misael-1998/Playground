using System;
using System.Collections.Generic;
using System.Text;

namespace Sesion3.Modelo
{
    class Cadenas
    {
        public void capturarCadena()
        {
            string texto;
            try
            {
                Console.WriteLine("Ingrese un texo");
                texto = Console.ReadLine();
               
            }
            catch (FormatException ex)
            {

               Console.WriteLine("No a ingresado un texto. Porfavor ingrese un texto");
                texto = " ";
            } 

            string[] text = texto.Split(' ');
            foreach (var cadena in text)
            {
                System.Console.WriteLine($"<{cadena}>");
            }


        }
    }
}
