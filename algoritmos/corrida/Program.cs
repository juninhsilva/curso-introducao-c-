using System;

namespace corrida
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(" ");
            int totalVoltas = int.Parse(entrada[0]);
            int totalPlacas = int.Parse(entrada[1]);
            int totalPlacasPercurso = totalVoltas * totalPlacas;

            for (int i = 10; i < 100; i += 10)
            {
                double totalPlacasParaCadaMeta = (double)totalPlacasPercurso / 100 * i;
                Console.WriteLine($"{Math.Ceiling(totalPlacasParaCadaMeta)} ");
            }
        }
    }
}
