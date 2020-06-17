
namespace Playground.Sesion7
{
    class Airport
    {

        public void TakeOffPlane() {

            Airplane plane = new Airplane();
            Duck duck = new Duck();
            IFlyable[] flyables = new IFlyable[3];
            flyables[0] = duck;
            flyables[1] = plane;
            flyables[2] = plane;
        }
    }
}
