﻿using Playground.Sesion2;
using Playground.Sesion8.Tipos.Aves;
using Playground.Session5.Guns;

namespace Playground.Extras
{
    class Licuadora
    {

        public Weapon Licuar(Pato pato, Weapon weapon, Resta resta)
        {
            int entero1 = pato.Name.Length;
            string texto = weapon.Name;
            float numero = resta.ObtenerValorActual();
            return new Arco();
        }

        public void Ejecutar()
        {
            Licuar(new Pato("Paco"), new Arco(), new Resta(0, 0)).MakeDamage();
        }

       

        
    }
}
