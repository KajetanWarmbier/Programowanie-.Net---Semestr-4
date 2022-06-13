using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_arrays_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            void Exercise_1()
            {
                Console.WriteLine("\n Exercise_1");

                for (int i=100; i > 0; i--)
                {
                    if(i%3 == 0 && i%2 != 0)
                    {
                        Console.Write(i + " ");
                    }
                }

                Console.WriteLine(" ");
                int j = 100;
                while (j > 0)
                {
                    if (j%3 == 0 && j%2 !=0)
                    {
                        Console.Write(j + " ");
                    }

                    j--;
                }

                Console.WriteLine(" ");
                int k = 100;
                do
                {
                    if (k%3 == 0 && k%2 != 0)
                    {
                        Console.Write(k + " ");
                    }

                    k--;
                } while (k > 0);

                Console.WriteLine(" ");
            }

            void Exercise_2()
            {
                Console.WriteLine("\n Exercise_2");

                int[][] tab = new int[4][];
                tab[0] = new int[1];
                tab[1] = new int[2];
                tab[2] = new int[3];
                tab[3] = new int[4];

                int count = 10;
                for (int i=0; i < tab.Length; i++)
                {
                    for (int j=0; j < tab[i].Length; j++)
                    {
                        tab[i][j] = count--;
                        Console.Write(tab[i][j] + " ");
                    }

                    Console.WriteLine(" ");
                }
            }

            void Exercise_3()
            {
                Console.WriteLine("\n Exercise_3");

                int[][] tab = new int[10][];
                tab[0] = new int[1];
                tab[1] = new int[1];
                tab[2] = new int[2];
                tab[3] = new int[3];
                tab[4] = new int[5];
                tab[5] = new int[8];
                tab[6] = new int[13];
                tab[7] = new int[21];
                tab[8] = new int[34];
                tab[9] = new int[55];

                for (int i=0; i < tab.Length; i++)
                {
                    for (int j=0; j < tab.Length; j++)
                    {
                        if (i==0 && j==0 || i==1 && j==0)
                        {
                            tab[i][j] = 1;
                            Console.Write("tab[{0}] = ", i);
                            Console.Write(tab[i][j] + " ");
                            break;
                        } else if (i > 1)
                        {
                            tab[i][j] = tab[i - 1][0] + tab[i - 2][0];
                            int count = tab[i][j];

                            Console.Write("tab[{0}] = ", i);

                            for (int k=0; k < count; k++)
                            {
                                Console.Write((tab[i][j]) - k + " ");
                            }

                            break;
                        }
                    }

                    Console.WriteLine("");
                }
            }


            Exercise_1();
            Exercise_2();
            Exercise_3();
            Console.ReadKey();
        }
    }
}
