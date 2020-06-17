using Playground.Sesion2;
using Playground.sesion3;
using Playground.Sesion7;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sesion 1
            // new HolaMundo().MostrarHolaMundo();


            // Sesion 2
            //new Calculadora().Calcular();

            //Sesion 3
            // new ShotGallery().EmptyAmmo();
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
            new Airport().TakeOffPlane();
        }
    }
}
