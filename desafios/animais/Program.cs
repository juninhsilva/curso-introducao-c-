using System;

namespace animais
{
    class Program
    {
        static void Main(string[] args)
        {
            String subfilo = Console.ReadLine();
            String classe = Console.ReadLine();
            String dieta = Console.ReadLine();

            if ((subfilo.Equals("vertebrado")) && ( classe.Equals("ave")) && ( dieta.Equals("carnivoro")))
            {
                Console.WriteLine("aguia");
            }

            if ((subfilo.Equals("vertebrado")) && (classe.Equals("ave")) && (dieta.Equals("onivoro")))
            {
                Console.WriteLine("pomba");
            }

            if ((subfilo.Equals("vertebrado")) && (classe.Equals("mamifero")) && (dieta.Equals("onivoro")))
            {
                Console.WriteLine("homem");
            }

            if ((subfilo.Equals("vertebrado")) && (classe.Equals("mamifero")) && (dieta.Equals("herbivoro")))
            {
                Console.WriteLine("vaca");
            }

            if ((subfilo.Equals("invertebrado")) && (classe.Equals("inseto")) && (dieta.Equals("hematofago")))
            {
                Console.WriteLine("pulga");
            }

            if ((subfilo.Equals("invertebrado")) && (classe.Equals("inseto")) && (dieta.Equals("herbivoro")))
            {
                Console.WriteLine("lagarta");
            }

            if (( subfilo.Equals("invertebrado")) && ( classe.Equals("anelideo")) && ( dieta.Equals("hematofago")))
            {
                Console.WriteLine("sanguessuga");
            }

            if ((subfilo.Equals("invertebrado")) && (classe.Equals("anelideo")) && (dieta.Equals("onivoro")))
            {
                Console.WriteLine("minhoca");
            }
        }
    }
}
