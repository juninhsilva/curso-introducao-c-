using System;

namespace consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 12;
            string[] line =Console.ReadLine().Split(" ");
            double resultado = double.Parse(line[0]) * double.Parse(line[1]) / media;
            Console.WriteLine(resultado.ToString("N3"));
        }
    }
}
