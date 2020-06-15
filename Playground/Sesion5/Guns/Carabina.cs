using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.Session5.Guns
{
    
    sealed class Carabina : Weapon 
    {
        public Carabina()
        {

        }

        public override void MakeDamage()
        {
            base.MakeDamage();
            Console.WriteLine("Carabina");
        }
    }
}
