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
            foreach ( Vaca vaca in _vacas)
            {
                if (vaca.Id == id )
                {
                    return vaca;
                }

            }
            // null representan nada 
            return null;
        }
        
        public bool VacaExiste(Vaca vaca)
        {

            for (int i = 0; i < _vacas.Length; i++)
            {
                if (vaca.Name == _vacas[i].Name  && vaca.Id == _vacas[i].Id)
                {
                    return true;
                }
                
            }
            return false;
        }

        public Vaca[] ObtenerLecheras()
        {
            int lechera = 0;
            for (int i = 0; i < _vacas.Length ; i++)
            {
                if (_vacas[i].TipoDeVaca == Tipo.LECHERA)
                {
                    lechera++;
                    
                }

            }
            Vaca[] vs = new Vaca[lechera];
            for (int i = 0; i < vs.Length; i++)
            {
                if (_vacas[i].TipoDeVaca == Tipo.LECHERA )
                {
                    vs[i] = _vacas[i];
                }
            }
            return _vacas;
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
