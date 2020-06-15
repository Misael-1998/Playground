using Playground.Session5.Guns;

namespace Playground.Session5
{
    class Shooter : Woman
    {
        public Shooter(string name, Races race) : base(name, race)
        {

        }

        public Weapon? CurrentWeapon { get; set; }

    }


}
