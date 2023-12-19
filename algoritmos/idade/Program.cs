using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeDias = Int32.Parse(Console.ReadLine());
            int anos = idadeDias / 365;
            int meses = (idadeDias % 365) / 30;
            int dias = (idadeDias % 365) % 30;
            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias+" dia(s)");
        }
    }
}
