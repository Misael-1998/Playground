using Playground.Session5;
using Playground.Session5.Guns;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Layla layla = new Layla();
            layla.CurrentWeapon?.MakeDamage();
            layla.Walk("san miguel");
            layla.CurrentWeapon = new Weapon { Name = "pistola" };
            layla.Speak();
            layla.Speak();
            layla.CurrentWeapon.MakeDamage();
        }
    }
}
