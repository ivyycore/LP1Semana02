﻿using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insire um número inteiro:");
            string askedNumber = Console.ReadLine();
            sbyte savedNumber = sbyte.Parse(askedNumber);
            sbyte savedNumber1 = sbyte.Parse(askedNumber);
            
            Console.WriteLine(--savedNumber);
            Console.WriteLine(++savedNumber1);
            
        }
    }
}