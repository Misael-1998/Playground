using Playground.Sesion7.Fabrica.Carroseria;
using Playground.Sesion7.Fabrica.Chasis;
using Playground.Sesion7.Fabrica.Frenos;
using Playground.Sesion7.Fabrica.Llantas;
using Playground.Sesion7.Fabrica.Motores;
using Playground.Sesion7.Fabrica.Suspension;

namespace Playground.Sesion7.Fabrica
{
    public class Carro : IChasis
    {
        private ILlanta[]? _llantas;
        private IMotor? _motor;
        private IFrenos[]? _frenar;
        private ISuspension[]? _suspension;
        private ICarroceria? _carroceria;
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
            if (_frenar != null)
            {
                foreach (IFrenos freno in _frenar)
                {
                    freno.Frenar();
                }
            }
            _motor?.Accelerar();
        }


        public void AgregarFrenos(IFrenos[] frenos)
        {
            _frenar = frenos;
        }

        public void AgregarSuspension(ISuspension[] suspender)
        {
            _suspension = suspender;
        }

        public void AgregarCarroceria(ICarroceria carroceria)
        {
            _carroceria = carroceria;
        }
    }

    
    }

