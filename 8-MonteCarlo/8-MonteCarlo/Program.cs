using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_MonteCarlo
{
    class Program
    {
        static void Main(string[] args)
        {

            void Exercise_1()
            {
                Console.Write("Podaj liczbę punktów do wygenerowania (więcej niż 3): ");
                string punkty = Console.ReadLine();

                int p = Convert.ToInt32(punkty);
                int v = 0;

                double x, y;
                Random rand = new Random();

                if (p <= 3)
                {
                    Console.WriteLine("Za mała liczba punktów by wyliczyć liczbę Pi.");
                }
                else
                {
                    for (int i = 1; i <= p; i++)
                    {
                        x = rand.NextDouble();
                        y = rand.NextDouble();

                        if ((x * x + y * y) <= 1)
                        {
                            v++;
                        }
                    }

                    double pi = 4 * (float)v / (float)p;
                    Console.WriteLine("Liczba Pi wynosi w przybliżeniu: {0}", pi);
                    string textToFile = Convert.ToString(pi) + ".";

                    File.WriteAllText(@"C:\temp\wynik_pi.txt", textToFile);
                }


            }

            Exercise_1();
            Console.ReadKey();
        }
    }
}
