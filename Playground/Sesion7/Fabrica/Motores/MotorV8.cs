using System;

namespace Playground.Sesion7.Fabrica.Motores
{
    class MotorV8 : IMotor
    {
        public void Accelerar()
        {
            Console.WriteLine("RUMMMM!!..... RUMMM....!!!!...RUM...");
        }
    }
}
