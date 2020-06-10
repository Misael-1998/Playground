
using System;

namespace Playground.Session5
{
    class Champion {

        /// <summary>
        /// Un enum sirve para representar conjuntos cerrados de opciones
        /// </summary>
        public enum Categories
        {
            Wizard = 0,
            Shooter,
            Tank,
            Support,
            Jungle
        }

        public enum Races
        {
            Human,
            Demon,
            Angel
        }

        public enum Genders
        {
            M,
            F
        }

        public string Name { get; set; } = "";

        public Champion(string name, Races race, Genders gender)
        {
            Name = name;
            Race = race;
            Gender = gender;
        }

        public Categories? Category { get; set; }

        public Races Race { get; }

        public Genders Gender { get; }


        public virtual void Speak()
        {
            Console.WriteLine("Yo hablo");
        }

        public void Walk(string place)
        {
            Console.WriteLine($"Yo camino al lugar {place}");
        }
    }
}
