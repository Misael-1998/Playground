
namespace Playground.sesion3
{
    class Uzi
    {
        public int Rounds { get; } = 2;
        public int Shots { get; } = 75;
        public string Name { get; } = "";

        public Uzi(string name)
        {
            Name = name;
        }

        public bool Shoot()
        {
            return true;
        }

        public void Reaload(Cartige ammo) {
        }
    }
}
