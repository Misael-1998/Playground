using Playground.Sesion7.Fabrica.Frenos;
using Playground.Sesion7.Fabrica.Llantas;
using Playground.Sesion7.Fabrica.Motores;

namespace Playground.Sesion7.Fabrica.Chasis
{
    public interface IChasis
    {
        public void AgregarLlantas(ILlanta[] llantas);

        public void AgregarMotor(IMotor motor);

        public void AgregarFrenos(IFrenos frenos);
    }
}
