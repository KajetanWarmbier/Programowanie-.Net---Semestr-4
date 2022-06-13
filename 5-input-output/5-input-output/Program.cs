using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_input_output
{
    class Program
    {
        static void Main(string[] args)
        {
            void Exercise_1()
            {
                Console.Write("Podaj tekst do zaszyfrowania: ");
                string text = Console.ReadLine();
                byte[] array = Encoding.ASCII.GetBytes(text.ToLower());

                Console.Write("Zakodowany tekst: ");
                for (int i=0; i < array.Length; i++)
                {
                    array[i] = (byte)(((array[i] - 96) % 27) + 97);
                }

                foreach (byte character in array)
                {
                    Console.Write((char)character);
                }

                Console.WriteLine("\nNaciśnij Q lub Escape by opuścić program.");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Q || keyInfo.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

            }

            void Exercise_2()
            {
                Console.Write("\nPodaj parametr A: ");
                string str_a = Console.ReadLine();
                double A = double.Parse(str_a);

                Console.Write("Podaj parametr B: ");
                string str_b = Console.ReadLine();
                double B = double.Parse(str_b);

                Console.Write("Podaj parametr C: ");
                string str_c = Console.ReadLine();
                double C = double.Parse(str_c);

                Console.WriteLine(A + "x^2 + " + B + "x + " + C);
                double delta = Math.Sqrt(B) - (4 * A * C);
                Console.WriteLine("Delta wynosi: " + delta);

                if (delta > 0)
                {
                    double x = ((-1 * B) - Math.Sqrt(delta)) / (2 * A);
                    double y = ((-1 * B) + Math.Sqrt(delta)) / (2 * A);
                    Console.WriteLine("Miejsca zerowe funkcji: " + x + " i " + y);
                } else if (delta == 0)
                {
                    double x = (-1 * B) / (2 * A);
                    Console.WriteLine("Miejsce zerowe funkcji: " + x);
                } else
                {
                    Console.WriteLine("Brak miejsc zerowych.");
                }
            }

            void Exercise_3()
            {
                Console.Write("\nWprowadź liczby oddzielając je przecinkami: ");
                string text = Console.ReadLine();
                string[] array_text = text.Split(',');
                double[] array_numbers = new double[array_text.Length];

                Console.Write("Wprowadzone liczby pierwsze: ");

                for (int i=0; i < array_text.Length; i++)
                {
                    array_numbers[i] = Convert.ToDouble(array_text[i]);
                }

                bool isPrime = true;
                for(int i=0; i < array_numbers.Length; i++)
                {
                    for(int j=2; j < array_numbers[i]; j++)
                    {
                        if(array_numbers[i]%j ==0)
                        {
                            isPrime = false;
                            break;
                        } else
                        {
                            isPrime = true;
                        }
                    }

                    if (isPrime)
                    {
                        Console.Write(array_numbers[i] + " ");
                    }
                }
            }

            Exercise_1();
            Exercise_2();
            Exercise_3();

            Console.ReadKey();
        }
    }
}
