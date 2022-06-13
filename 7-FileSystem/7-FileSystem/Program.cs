using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            void Exercise_1()
            {
                Console.Write("Nazwa katalogu: ");
                string folder = Console.ReadLine();

                Console.Write("Nazwa pliku: ");
                string file = Console.ReadLine();
                file += ".txt";

                string list = "";
                Random rand = new Random();

                for(int i=0; i < 10; i++)
                {
                    int value = rand.Next(1, 51);
                    list += value.ToString() + " ";
                }

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                    File.WriteAllText(Path.Combine(folder, file), list);
                }

                string text = File.ReadAllText(Path.Combine(folder, file));
                Console.WriteLine("Liczby znajdujące się w pliku: {0}", text);

                int[] numbers_array = new int[10];
                numbers_array = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                void QuickSort(int[] array, int left, int right)
                {
                    int x = left;
                    int y = right;
                    int pivot = array[(left + right) / 2];
                    
                    while (x < y)
                    {
                        while (array[x] < pivot) x++;
                        while (array[y] > pivot) y--;
                        if (x <= y)
                        {
                            int temp = array[x];
                            array[x++] = array[y];
                            array[y--] = temp;
                        }
                    }
                    if (left < y) QuickSort(array, left, y);
                    if (right > x) QuickSort(array, x, right);
                }

                QuickSort(numbers_array, 0, numbers_array.Length - 1);

                Console.WriteLine("Posortowane liczby: ");
                Console.WriteLine(string.Join(" ", numbers_array));
            }

            void Exercise_2()
            {
                Console.Write("\nCo usunąć: katalog/plik ");
                string answear = Console.ReadLine();
                answear = answear.ToLower();
                Console.Write("Podaj nazwę {0}u ", answear);
                string name = Console.ReadLine();

                string consent;

                if (answear == "katalog")
                {
                    Console.Write("Czy chcesz usunąć katalog {0}: tak/nie ", name);
                    consent = Console.ReadLine();

                    if (consent == "tak")
                    {
                        Directory.Delete(name);
                    } else
                    {
                        Console.WriteLine("Katalog o nazwie {0} nie zotał usunięty ", name);
                    }
                } else if (answear == "nie"){
                    Console.Write("Czy chcesz usunąć plik {0}: tak/nie ", name);
                    consent = Console.ReadLine();

                    if(consent == "tak")
                    {
                        File.Delete(name);
                    } else
                    {
                        Console.WriteLine("Plik o nazwie {0} nie zotał usunięty", name);
                    }
                } else
                {
                    Console.WriteLine("Nastąpił błąd.");
                }
            }

            void Exercise_3()
            {
                Console.Write("\nNazwa katalogu: ");
                string folder = Console.ReadLine();
                long ammount = 0;

                DirectoryInfo dir = new DirectoryInfo(folder);
                FileInfo[] fileInf = dir.GetFiles();

                Console.WriteLine("Katalog {0} zawiera: ", dir.Name);
                foreach(FileInfo fi in fileInf)
                {
                    Console.WriteLine("Plik {0} waży {1}", fi.Name, fi.Length);
                    ammount += fi.Length;
                }

                Console.WriteLine("Pliki w katalogu {0} ważą łącznie {1}", dir.Name, ammount);
            }

            Exercise_1();
            Exercise_2();
            Exercise_3();

            Console.ReadKey();
        }
    }
}
