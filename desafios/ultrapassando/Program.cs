using System;
using System.Collections.Generic;
using System.Linq;

namespace ultrapassando
{
    class Program
    {
        static void Main(string[] args)
        {
            var R = Int32.Parse(Console.ReadLine());
            var V = 0;
            int contador = 1;

            do
            {
                V = Int32.Parse(Console.ReadLine());
            } while (V <= R);

            int aux = R;

            while (aux <= V)
            {
                contador++;
                R += 1;
                aux += R;
            }

            Console.WriteLine(contador);
        }
    }
}
