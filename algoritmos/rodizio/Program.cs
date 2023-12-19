using System;
using System.Text.RegularExpressions;

namespace rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
            int testes;
            Match match;
            string regex = @"^[A-Z]{3}\-\d{4}$";
            string[] resultados = {"SEGUNDA","TERCA","QUARTA","QUINTA","SEXTA","FALHA"};
            do
            {
                testes = Int32.Parse(Console.ReadLine());
            } while (testes < 0 || testes > 1000);
            string[] placas = new string[testes];
            for(int i =0; i<testes;i++){
                placas[i] = Console.ReadLine();
                match = Regex.Match(placas[i], regex);
                if (match.Success){
                    if(placas[i].EndsWith('1')||placas[i].EndsWith('2')){
                        Console.WriteLine(resultados[0]);
                    }
                    else if(placas[i].EndsWith('3') || placas[i].EndsWith('4'))
                    {
                        Console.WriteLine(resultados[1]);
                    }
                    else if (placas[i].EndsWith('5') || placas[i].EndsWith('6'))
                    {
                        Console.WriteLine(resultados[2]);
                    }
                    else if (placas[i].EndsWith('7') || placas[i].EndsWith('8'))
                    {
                        Console.WriteLine(resultados[3]);
                    }
                    else if (placas[i].EndsWith('9') || placas[i].EndsWith('0'))
                    {
                        Console.WriteLine(resultados[4]);
                    }
                }
                else
                    Console.WriteLine(resultados[5]);
            }
        }
    }
}
