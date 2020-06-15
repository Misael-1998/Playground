using System;

namespace Playground.Session5
{
    sealed class Layla : Shooter
    {
        public Layla() : base(nameof(Layla), Races.Human)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Hola <3!");
        }
    }
}
