
namespace Playground.Session5
{
    class Woman : Champion
    {
        public Woman(string name, Races race) : base(name, race, Genders.F)
        {
        }

        public string? Hair { get; set; }
    }
}
