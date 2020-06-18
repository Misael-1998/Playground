
namespace Playground.Sesion8
{
    public enum Genero
    {
        Macho,
        Hembra
    }
    
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Edad { get; set; } = 0;
        public Genero Genero { get; set; }
        
        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Aparearce();
        public abstract void Comer();
        public abstract void Dormir();

    }
}