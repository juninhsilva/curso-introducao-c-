﻿using System;

namespace minutos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(" ");
            int tempoSegundos = int.Parse(line[0]);
            int horas = tempoSegundos / 3600;
            int minutos = (tempoSegundos % 3600) / 60;
            int segundos = (tempoSegundos % 3600) % 60;
            Console.Write($"{horas}:{minutos}:{segundos}");
        }
    }
}
