using Playground.Sesion2;
using Playground.sesion3;
using Playground.sesion3.Extra;
using Playground.Sesion7;
using Playground.Sesion7.Fabrica;
using Playground.Sesion8;

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
            //new Establo().EstabloVacio();
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
             new Ensamblador().EnsamblarCarro(Modelos.Lanser).Avanazar();
            
            // Sesion 8
            //Zoo.AlimentarAnimales();
            
        }
    }
}
