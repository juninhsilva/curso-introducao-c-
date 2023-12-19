using System;

namespace elfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            do
            {
                tempo = Int32.Parse(Console.ReadLine());
            }while (tempo < 0 || tempo > 100);
            string[] line = Console.ReadLine().Split(" ");
            int brinquedo1 = Int32.Parse(line[0]);
            int brinquedo2 = Int32.Parse(line[1]);
            if(brinquedo1+brinquedo2>tempo)
                Console.WriteLine("Deixa para amanha!");
            else 
                Console.WriteLine("Farei hoje!");
        }
    }
}
