using System;
using Playground.Sesion7.Fabrica.Frenos;
using Playground.Sesion7.Fabrica.Llantas;
using Playground.Sesion7.Fabrica.Motores;

namespace Playground.Sesion7.Fabrica
{
    public enum Modelos
    {
        Lanser,
        N350Z
    }

    class Ensamblador
    {

        private ILlanta[] HacerLlantas(int tipo)
        {
            return tipo switch
            {
                0 => new ILlanta[]
                {
                    new Maxxis(),
                    new Maxxis(),
                    new Maxxis(),
                    new Maxxis(),
                    
                },
                1 => new ILlanta[]
                {
                    new Enkei(),
                    new Enkei(),
                    new Enkei(),
                    new Enkei()
                },
                _ => new ILlanta[]
                {
                    new Maxxis(),
                    new Maxxis(),
                    new Enkei(),
                    new Maxxis()
                },
            };
        }

       
        

        private IMotor HacerMotor(int tipo)
        {
            return tipo switch
            {
                0 => new Motor4Cilindros(),
                1 => new MotorV8(),
                _ => new Motor4Cilindros()
            };
        }

        private IFrenos HacerFrenos(int tipo)
        {
            return tipo switch
            {
                0 => new Boschcs(),
                1 => new Brembo()
            };
        }

      

        public Carro EnsamblarCarro(Modelos modelo)
        {
            switch (modelo)
            {
                case Modelos.Lanser:
                    Lancer lancer = new Lancer();
                    lancer.AgregarLlantas(HacerLlantas(0));
                    lancer.AgregarMotor(HacerMotor(1));
                    lancer.AgregarFrenos(HacerFrenos(0));
                    
                    return lancer;
                case Modelos.N350Z:
                    N350Z nissan = new N350Z();
                    nissan.AgregarLlantas(HacerLlantas(1));
                    nissan.AgregarMotor(HacerMotor(1));
                    nissan.AgregarFrenos(HacerFrenos(1));
                    
                    return nissan;
                default:
                    throw new ArgumentOutOfRangeException(nameof(modelo), modelo, null);
            }
        }
    }
}
