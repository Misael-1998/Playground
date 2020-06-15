using System;

namespace Playground.sesion3
{
    class Iterador
    {

        public void PrintLinesFor(string[] lines)
        {
            /* El for, whilr if y todas las estructuras de control solo
            * ejecutan la linea inmediatamente siguiente a ellas, pero si hay
            * varias instrucciones que deben ejecutarse estas deben estar
            * encerradas en un scope es decir entre { y }
            */
            for (int x = 0; x < lines.Length; x++)
                Console.WriteLine(lines[x]);

        }

        public void PrintLinesWhile(string[] lines)
        {
            int x = 0;
            while (x < lines.Length)
            {
                Console.WriteLine(lines[x]);
                x++;
            }
        }

        public void PrintLinesDoWhile(string[] lines)
        {
            if (lines.Length < 1) return;
            int x = 0;
            do
            {
                Console.WriteLine(lines[x]);
                x++;
            } while (x < lines.Length);
        }

        public void PrintLinesForEach(string[] lines)
        {
            foreach(string mokito in lines)
            {
                Console.WriteLine(mokito);
            }
        }


    }
}
