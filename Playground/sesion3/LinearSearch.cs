
using System;

namespace Playground.sesion3
{
    class LinearSearch
    {

        public bool Search(int y, params int[] x) {
            int x2;
            bool wasFound = false;
            for (int j = 0; j < x.Length; j++)
            {
                x2 = x[j];
                if (x[j] == y)
                {
                    Console.WriteLine($"Se encontro que {y} == {x2}");
                    wasFound = true;
                    break;
                }
                Console.WriteLine($"Se encontro que {y} != {x2}");
            }
            
            return wasFound;
        }

        public void PrintUntil(int y, params int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (y == x[i])
                {
                    continue;
                }
                Console.WriteLine($"Se encontro que {x[i]} xd");
            }
        }
    }
}
