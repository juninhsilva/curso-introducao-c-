using System;
using System.Linq;

namespace figurinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeFigurinhas;
            int numeroDeFigurinhasCompradas;
            int totalDeFigurinhas = 0;
            int figurinhasDiferentes = 0;
            do{
                numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
            }while(numeroDeFigurinhas < 1 || numeroDeFigurinhas > 100);
            do{
                numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
            }while(numeroDeFigurinhasCompradas < 1 || numeroDeFigurinhasCompradas > 300);            

            int[] albumDeFigurinha = new int[numeroDeFigurinhas];
            int[] figurinhasCompradas = new int[numeroDeFigurinhasCompradas];

            for (int i = 0; i < numeroDeFigurinhasCompradas; i++)
            {
                figurinhasCompradas[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numeroDeFigurinhasCompradas; i++)
            {
                int figurinha = figurinhasCompradas[i] - 1;
                if (albumDeFigurinha[figurinha] == 0)
                {
                    albumDeFigurinha[figurinha] = 1;
                    figurinhasDiferentes++;
                }
            }

            totalDeFigurinhas = numeroDeFigurinhas - figurinhasDiferentes;

            Console.WriteLine(totalDeFigurinhas);
        }
    }
}
