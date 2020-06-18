using System;
using Playground.Sesion8.Habilidades;

namespace Playground.Sesion8.Tipos.Aves
{
    public class Pinguino: Ave, ICaminador, INadador
    {
        public void Caminar()
        {
            throw new System.NotImplementedException();
        }

        public void Nadar()
        {
            throw new System.NotImplementedException();
        }

        public Pinguino(string name) : base(name)
        {
        }

        public override void Aparearce()
        {
            throw new System.NotImplementedException();
        }

        public override void Comer()
        {
            Console.WriteLine($"{Name} sfksflsflsb {nameof(Pinguino)}");
        }

        public override void Dormir()
        {
            throw new System.NotImplementedException();
        }
    }
}