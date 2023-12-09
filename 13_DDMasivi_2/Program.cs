using System;

namespace _13_DDMasivi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadiet rindu skaitu: ");
            int rinduSkaits = int.Parse(Console.ReadLine());

            Console.Write("Ievadiet kolonnu skaitu: ");
            int kolonnuSkaits = int.Parse(Console.ReadLine());

            int[,] masivs = new int[rinduSkaits, kolonnuSkaits];

            Random rand = new Random();
            for (int i = 0; i < rinduSkaits; i++)
            {
                for (int j = 0; j < kolonnuSkaits; j++)
                {
                    if ((i + j) % 2 == 1)
                    {
                        masivs[i, j] = 0;
                    }
                    else
                    {
                        masivs[i, j] = rand.Next(10, 100);
                    }
                }
            }

            // Raksts šaha laukumiņa stilā
            Console.WriteLine("\n Katrs otrais elements = 0");
            Console.WriteLine();

            for (int i = 0; i < rinduSkaits; i++)
            {
                for (int j = 0; j < kolonnuSkaits; j++)
                {
                    Console.Write($"{masivs[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}