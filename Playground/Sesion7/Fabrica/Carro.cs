using Playground.Sesion7.Fabrica.Chasis;
using Playground.Sesion7.Fabrica.Frenos;
using Playground.Sesion7.Fabrica.Llantas;
using Playground.Sesion7.Fabrica.Motores;

namespace Playground.Sesion7.Fabrica
{
    public class Carro : IChasis
    {
        private ILlanta[]? _llantas;
        private IMotor? _motor;
        private IFrenos? _frenar;

        public void AgregarLlantas(ILlanta[] llantas)
        {
            _llantas = llantas;
        }

        public void AgregarMotor(IMotor motor)
        {
            _motor = motor;
        }



        public void Avanazar()
        {
            if (_llantas != null)
            {
                foreach (ILlanta llanta in _llantas)
                {
                    llanta.Rodar();
                }
            }
            _motor?.Accelerar();
        }

        public void AgregarFrenos(IFrenos frenos)
        {
            _frenar = frenos;
        }
       
    }

    
    }

