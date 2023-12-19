using System;

namespace notas
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            double media = 0;
            double[] notas = new double[2];
            do
            {
                double nota = Double.Parse(Console.ReadLine());
                if(nota >=0 && nota <=10){
                    notas[index] = nota;
                    index++;
                }else{
                    Console.WriteLine("nota invalida");
                }
            } while (index < 2);
            media=(notas[0]+notas[1])/2;
            Console.WriteLine("media = " + media.ToString("N2"));
        }
    }
}
