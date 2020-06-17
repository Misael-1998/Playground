
using System;
using Playground.Sesion7.Fabrica;

namespace Playground.Sesion7
{
    class Airport
    {

        public void TakeOffPlane() {

            Airplane plane = new Airplane();
            Duck duck = new Duck();
            Misil misil = new Misil();
            IFlyable[] flyables = new IFlyable[3];
            flyables[0] = duck;
            flyables[1] = plane;
            flyables[2] = misil;

            foreach (IFlyable volador in flyables)
            {

                volador.Fly();
               

            }
            foreach (IFlyable aterrizar in flyables)
            {
                aterrizar.Land();
            }
            CorrerCarros();
        }

        private void CorrerCarros()
        {
            Ensamblador e = new Ensamblador();
            e.EnsamblarCarro(Modelos.Lanser).Avanazar();
            e.EnsamblarCarro(Modelos.N350Z).Avanazar();
        }
    }
}
