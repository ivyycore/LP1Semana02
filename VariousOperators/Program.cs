﻿using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro-não negativo:");
            string askNumber = Console.ReadLine();
            byte saveNumber = byte.Parse(askNumber);

            Console.WriteLine(saveNumber/2);
            Console.WriteLine(saveNumber<<3);
            Console.WriteLine(saveNumber^6);
            Console.WriteLine(saveNumber>10);
        }
    }
}