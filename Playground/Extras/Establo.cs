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
            foreach (Vaca vaca in _vacas)
            {
                if (vaca.Id == id)
                {
                    return vaca;
                }
            }

            // null representan nada 
            return null;
        }

        public bool VacaExiste(Vaca vaca)
        {
            foreach (var t in _vacas)
            {
                if (vaca.Name == t.Name && vaca.Id == t.Id)
                {
                    return true;
                }
            }

            return false;
        }

        public Vaca[] ObtenerLecheras()
        {
            int lechera = 0;
            for (int i = 0; i < _vacas.Length; i++)
            {
                if (_vacas[i].TipoDeVaca == Tipo.LECHERA)
                {
                    lechera++;
                }
            }

            Vaca[] vs = new Vaca[lechera];
            int index = 0;
            for (int i = 0; i < _vacas.Length; i++)
            {
                if (_vacas[i].TipoDeVaca == Tipo.LECHERA)
                {
                    vs[index] = _vacas[i];
                    index++;
                }
            }

            return vs;
        }

        public Vaca[] OrdenarPorTazaDeProduccion()
        {
            throw new NotImplementedException();
        }

        public void ClasificarVaca(Vaca vaca)
        {
            throw new NotImplementedException();
        }

        public Vaca? ObtenerLaMasLechera()
        {
            if (_vacas.Length < 1)
            {
                return null;
            }
            
            Vaca maximo = _vacas[0];
            
            foreach (var t in _vacas)
            {
                if (t.TazaDeProccion > maximo.TazaDeProccion)
                {
                    maximo = t;
                }
            }

            return maximo;
        }

        public Vaca? ObtenerLaMenosLechera()
        {
            if (_vacas.Length <1)
            {
                return null;
            }
            Vaca minimo = _vacas[0];
            for (int i = 0; i <_vacas.Length; i++)
            {
                if (_vacas[i].TazaDeProccion < minimo.TazaDeProccion )
                {
                    minimo = _vacas[i];
                }
            }
            return minimo;
        }

        public Vaca[] ObtenerVacasRepetidas()
        {
            throw new NotImplementedException();
        }
    }
}