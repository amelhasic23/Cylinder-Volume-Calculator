using System;

namespace VolumeCalculator
{
    class Cylinder
    {
        static void Main(string[] args)
        {
            // Definišemo konstante
            double radius = 10; // Poluprečnik osnove valjka
            double height = 50; // Visina valjka
            double pi = 3.14;   // Vrednost konstante Pi

            // Formula za zapreminu valjka: V = π * r^2 * h
            double volume = pi * Math.Pow(radius, 2) * height;

            // Ispis rezultata
            Console.WriteLine($"Zapremina valjka sa poluprečnikom {radius} i visinom {height} iznosi: {volume}");
        }
    }
}

