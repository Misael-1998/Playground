using System;
using BancoShell.Modelos;
using Playground.Sesion2;
using Playground.sesion3;

namespace Playground
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            foreach(string argument in args)
            {
                Console.WriteLine(argument);
            }

            if (args.Length < 1)
            {
                Console.WriteLine("Debe escoger una opcion numerica del 1 al 9");
                return -1;
            }

            if (!int.TryParse(args[0], out int opcion))
            {
                Console.WriteLine("Debe escoger una opcion numerica del 1 al 9");
                return -1;
            }

            if (opcion < 1 || opcion > 9)
            {
                Console.WriteLine("Debe escoger una opcion numerica del 1 al 9");
                return -1;
            }

            switch (opcion)
            {
                case 1:
                    // Sesion 1
                    new HolaMundo().MostrarHolaMundo();
                    break;
                case 2:
                    // Sesion 2
                    new Calculadora().Calcular();
                    break;
                case 3:
                    // Sesion 3
                    new ShotGallery().EmptyAmmo();
                    break;
            }


            /*
            Layla layla = new Layla();
            layla.CurrentWeapon?.MakeDamage();
            layla.Walk("san miguel");
            layla.CurrentWeapon = new Carabina { Name = "pistola" };
            layla.Speak();
            layla.Speak();
            layla.CurrentWeapon.MakeDamage();
            layla.Walk("San Salvador");
            layla.CurrentWeapon = new Arco();
            layla.CurrentWeapon?.MakeDamage();
            layla.Walk("Soya");
            layla.CurrentWeapon = new Metralleta();
            layla.CurrentWeapon?.MakeDamage();
            layla.CurrentWeapon = null;
            */

            // Sesion 6
            // new Airport().TakeOffPlane();

            // Sesion7
            // new Ensamblador().EnsamblarCarro(Modelos.Lanser).Avanazar();

            // Sesion 8
            // Zoo.AlimentarAnimales();

            // Extrax
            //new Licuadora().Ejecutar();
            return 0;
        }
    }
}