using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Playground.sesion3.Extra
{
    class Vacas
    {
        private int vaca;

        public Vacas(int ganado)
        {
            vaca = ganado;
        }

        public bool Entrar()
        {
            return vaca > 0;
        }

        public int ObtenerVaca()
        {
            vaca--;
            return vaca;
        }
    }
}
