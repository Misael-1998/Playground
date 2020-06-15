
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
            throw new NotImplementedException();
        }

        public void Reaload(Cartige ammo)
        {
            Rounds = ammo;
        }
    }
}
