using System;

namespace Playground.Sesion2
{
    class multiplicacion
    {
        //Campos privados
        private int _x;
        private int _y;

        public int add(int x, int y)
        {
            return x * y;
        }

        public decimal add(decimal x, decimal y)
        {
            return x * y;
        }

        public multiplicacion(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int ObtenerValorActual() => _x * _y;

        public static int MultiplicacionXd(multiplicacion multiA, int multiB)
        {
            int multi1 = multiA.ObtenerValorActual();
            multiplicacion Multiplicacion = new multiplicacion(multi1,multiB);
            return Multiplicacion.ObtenerValorActual();

        }

        public void operacion(int tipoDato)
        {
            string caracter1;
            string caracter2;

            Console.WriteLine("Ingrese le valor 1");
            caracter1 = Console.ReadLine();
            Console.WriteLine("Ingrese le valor 2");
            caracter2 = Console.ReadLine();
            Console.WriteLine("tipo de dato seleccionado" + tipoDato);
            try
            {
                switch (tipoDato)
                {
                    case 1:
                        int caract1 = Convert.ToInt32(caracter1);
                        int caract2 = Convert.ToInt32(caracter2);
                        Console.WriteLine("Su resultado es" + add(caract1, caract2));
                        break;
                    case 2:
                        decimal operacion = Convert.ToDecimal(caracter1);
                        decimal operacion2 = Convert.ToDecimal(caracter2);
                        Console.WriteLine("Su resultado es" + add(operacion, operacion2));
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Ingrese los valores segun el tipo de dato seleccionado");

            }
        }


    
}
}
