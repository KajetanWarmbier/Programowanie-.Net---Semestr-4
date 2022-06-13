using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _4_exceptions
{
    class Program
    {
        public class BubbleSort
        {
            public BubbleSort(int[] array)
            {
                int temp;

                for (int i=0; i < array.Length-1; i++)
                {
                    for (int j=0; j < array.Length-1; j++)
                    {
                        if (array[j] > array[j+1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }

                foreach (int number in array)
                {
                    Console.Write(number + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            void Exercise_1()
            {
                Console.WriteLine("Podaj dwie liczby: ");

                

                try
                {
                    Console.Write("Podaj liczbę nr 1: ");
                    string num1 = Console.ReadLine();
                    Console.Write("Podaj liczbę nr 2: ");
                    string num2 = Console.ReadLine();
                    double x = int.Parse(num1);
                    double y = int.Parse(num2);

                    Console.WriteLine(x / y);
                } catch (ArithmeticException e)
                {
                    MessageBox.Show(e.Message);
                    Console.WriteLine(e.Message);
                } catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    Console.WriteLine(e.Message);
                }
            }

            void Exercise_2()
            {
                int[] array = new int[10];

                Console.WriteLine("\nPodaj 10 dowolnych liczb całkowitych: ");

                try
                {
                    for (int i=0; i<10; i++)
                    {
                        Console.Write("Podaj liczbę nr {0}: ", i + 1);
                        string num1 = Console.ReadLine();
                        int x = int.Parse(num1);
                        array[i] = x;
                    }
                } catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("\nLiczby posortowane rosnąco: ");
                new BubbleSort(array);
            }


            Exercise_1();
            Exercise_2();
            Console.ReadKey();
        }
    }
}
