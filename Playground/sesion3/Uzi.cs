
using System;

namespace Playground.sesion3
{
    class Uzi
    {
        public Cartige? Rounds { get; set; }
        public string Name { get; } = "";

        public Uzi(string name)
        {
            Name = name;
        }

        public bool Shoot()
        {
            if (Rounds == null)
            {
                Console.WriteLine("click");
                return false;
            }

            if (Rounds.HasNext())
            {

                int numeroBala = Rounds.GetBullet();
                Console.WriteLine($"{Name}--piu{numeroBala}");
                return true;
            }
            else
            {
                Console.WriteLine("click");
                return false;
            }

        }

        public void Reaload(Cartige ammo)
        {
            Rounds = ammo;
        }
    }
}
