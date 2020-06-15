using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.Session5.Guns
{
    class Metralleta : Weapon
    {
        public override void MakeDamage()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ratarataratarataratarata");
            }
            
        }
    }
}
