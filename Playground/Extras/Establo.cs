using System;

namespace Playground.Extras
{
    public class Establo
    {
        private Vaca[] _vacas;
        
        public Establo(Vaca[] vacas)
        {
            _vacas = vacas;
        }
        
        public Vaca? BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }
        
        public bool VacaExiste(Vaca vaca)
        {
            throw new NotImplementedException();
        }

        public Vaca[] ObtenerLecheras()
        {
            throw new NotImplementedException();   
        }
        
        public Vaca[] ObtenerPorTazaDeProduccion()
        {
            throw new NotImplementedException();
        }

        public void ClasificarVaca(Vaca vaca)
        {
            throw new NotImplementedException();
        }
        
        public Vaca ObtenerLaMasLechera()
        {
            throw new NotImplementedException();
        }
        
        public Vaca ObtenerLaMenosLechera()
        {
            throw new NotImplementedException();
        }
        
        public Vaca[] ObtenerVacasRepetidas()
        {
            throw new NotImplementedException();
        }

    }
}
