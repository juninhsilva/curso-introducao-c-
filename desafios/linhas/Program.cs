﻿using System;

namespace linhas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do{
                n = Int32.Parse(Console.ReadLine());
            }while(n<1||n>=1000);
            for(int i=1; i<=n;i++){
                Console.WriteLine(i+" "+i*i+" "+i*i*i);
            }
        }
    }
}
