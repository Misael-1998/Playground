﻿using System;

namespace Playground.Session5.Guns
{
    class Weapon
    {
        public string Name { get; set; }

        public virtual void MakeDamage()
        {
            Console.WriteLine("daño");
        }
    }
}
