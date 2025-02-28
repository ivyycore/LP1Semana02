﻿using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Altura do cilindro");
            string a = Console.ReadLine();
            Console.WriteLine("Raio do cilindro");
            string r = Console.ReadLine();  

            double a1 = double.Parse(a);
            double r1 = double.Parse(r);

            double V = (Math.PI*(r1*r1)*a1);
            double S = (2*Math.PI*r1*(r1+a1));

            string resultadoV = $"{V:f3}";
            string resultadoS = $"{S:f3}";
            
            Console.WriteLine($"Volume do cilindro: {resultadoV}");
            Console.WriteLine($"Área da superfífcie do cilindro: {resultadoS}");
        }
    }
}