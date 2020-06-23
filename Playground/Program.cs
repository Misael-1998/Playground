using System;
using BancoShell.Modelos;
using Playground.Extras;
using Playground.Sesion2;
using Playground.sesion3;
using Playground.Sesion7;
using Playground.Sesion7.Fabrica;
using Playground.Sesion8;
using Playground.Session5;
using Playground.Session5.Guns;

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
                case 4:
                    //Sesion4
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
                    break;
                case 5:
                    // Sesion6
                    new Airport().TakeOffPlane();
                    break;

                case 6:
                    // Sesion7
                    new Ensamblador().EnsamblarCarro(Modelos.Lanser).Avanazar();
                    break;
                case 7:
                    // Sesion8
                    Zoo.AlimentarAnimales();
                    break;
                case 8:
                    new Licuadora().Ejecutar();
                    break;
            }
            return 0;
        }
    }
}