using System;
using System.Collections.Generic;
using System.Text;

namespace Playground.sesion3.Extra
{
    class Establo
    {
        public void EstabloVacio()
        {
            Ganado[] toros = new Ganado[10];
            Vacas[] vacas = new Vacas[30];
            for (int i = 0; i < toros.Length; i++)
            {
                toros[i] = new Ganado($"vaca{i}");
                vacas[i + 0] = new Vacas(10);
            }
            for (int x = 0; x < toros.Length; x++)
            {
                toros[x].VolverEntrar(vacas[x]);
                while (toros[x].Entrar());
                toros[x].VolverEntrar(vacas[x + 10]);
                while (toros[x].Entrar());
            }
        }
    }
}
