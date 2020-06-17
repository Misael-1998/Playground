using System;

namespace Playground.Sesion7.Fabrica.Motores
{
    class Motor4Cilindros : IMotor
    {
        public void Accelerar()
        {
            Console.WriteLine("brum.....brumm...brum...");
        }
    }
}
