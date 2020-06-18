using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using Playground.Sesion8.Habilidades;

namespace Playground.Sesion8.Tipos.Aves
{
    public class Pato: Ave, ICaminador, INadador, IVolador
    {
        public void Caminar()
        {
            throw new System.NotImplementedException();
        }

        public void Nadar()
        {
            throw new System.NotImplementedException();
        }

        public void Volar()
        {
            throw new System.NotImplementedException();
        }

        public Pato(string name) : base(name)
        {
        }

        public override void Aparearce()
        {
            throw new System.NotImplementedException();
        }

        public override void Comer()
        {
            throw new System.NotImplementedException();
        }

        public override void Dormir()
        {
            throw new System.NotImplementedException();
        }
    }
}