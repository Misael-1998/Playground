namespace Playground.Sesion2
{
    class Suma
    {
        private int _x;
        private int _y;
        

        public Suma()
        {
        }

        

        public Suma(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Suma Add(int z)
        {
            _x += _y;
            _y = z;
            return this;
        }

        public int ObtenerValorActual() => _x + _y;

        public int Add(int x, int y)
        {
            return x + y;
        }
        public Suma Add(Suma sumaA, Suma sumaB)
        {
            int suma1 =  sumaA.ObtenerValorActual();
            int suma2 = sumaB.ObtenerValorActual();
            Suma suma = new Suma(suma1,suma2);
            return suma;
        }
        public decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public float Add(float x, float y)
        {
            return x + y;
        }

        public bool TryAdd(string numberA, string numberB, out decimal result)
        {
            bool n1 = decimal.TryParse(numberA, out decimal x);
            bool n2 = decimal.TryParse(numberB, out decimal y);

            if (n1 && n2)
            {
                result = x + y;
                return true;
            }
            else
            {
                result = 0;
                return false;
            }
        }


        public int Add(int[] numbers)
        {
            int acumulado = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                acumulado += numbers[i];
            }
            return acumulado;
        }

        public int Add(params int[] number)
        {
            int acumulado = 0;
            for (int i = 0; i < number.Length; i++)
            {
                acumulado += number[i];
            }

            return acumulado;
        }
    }
}