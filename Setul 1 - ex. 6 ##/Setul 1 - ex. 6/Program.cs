using System;

namespace Setul_1___ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 

            int a, b, c;

            a = int.Parse(Console.ReadLine());
            Console.WriteLine();

            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            c = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (a > 0 && b > 0 && c > 0)
            {
                if (a < b + c && b < a + c && c < a + b)
                    Console.WriteLine($"Numerele {a}, {b} si {c} pot fi laturile unui triunghi.");
                else
                    Console.WriteLine($"Numerele {a}, {b} si {c} nu pot fi laturile unui triunghi.");
            }
            else
                Console.WriteLine($"Numerele {a}, {b} si {c} nu pot fi laturile unui triunghi.");
        }
    }
}
