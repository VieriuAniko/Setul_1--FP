using System;

namespace Setul_1___ex._21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indicatie: Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

            Random random = new Random();
            int numarul = random.Next(1, 1025);
            bool gasit = false;

            while (!gasit)
            {
                Console.WriteLine("Introdu numarul care crezi ca e potrivit.");

                if (int.TryParse(Console.ReadLine(), out int ghiciUser))
                {
                    if (ghiciUser < numarul)
                        Console.WriteLine("Numarul este mai mare. Mai incearca.");
                    else
                        if (ghiciUser > numarul)
                        Console.WriteLine("Numarul este mai mic. Mai incearca.");
                    else
                    {
                        gasit = true;
                        Console.WriteLine("Felicitari! Ai ghicit numarul :)");
                    }
                }
                else
                {
                    Console.WriteLine("Numarul introdus nu este valid. Incearca din nou.");
                }
            }
        }
    }
}
