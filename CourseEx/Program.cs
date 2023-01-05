﻿using System;
using System.Globalization;
namespace CourseEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Retangulo r = new Retangulo();
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}