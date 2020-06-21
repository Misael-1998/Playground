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
            int[] lista = {1,2,3,4,5};
            Boolean respuesta = false;
            Console.WriteLine("Ingrese un id");
            id = int.Parse(Console.ReadLine());

            while (!(respuesta)&& id < 5)
            {
                if (id == lista[id] )
                {
                    respuesta = true;
                }
            }
           
            
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
