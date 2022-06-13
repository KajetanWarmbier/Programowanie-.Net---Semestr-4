using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_constructor_overloading
{
    public class Constructor
    {
        double liczba;
        char znak;

        public Constructor(double arg)
        {
            this.liczba = arg;
            Console.WriteLine("Constructor_1: " + liczba);
        }

        public Constructor(char arg)
        {
            this.znak = arg;
            Console.WriteLine("Constructor_2: " + znak);
        }

        public Constructor(double argD, char argC)
        {
            this.liczba = argD;
            this.znak = argC;
            Console.WriteLine("Constructor_3: " + liczba + " & " + znak);
        }

        public Constructor(double argD1, double argD2)
        {
            while (argD1 != argD2)
            {
                if (argD1 > argD2)
                {
                    argD1 -= argD2;
                } else
                {
                    argD2 -= argD1;
                }
            }

            Console.WriteLine("Constructor_4: " + argD1);
        }

        public Constructor(int[] array)
        {
            Console.Write("Constructor_5: ");

            bool isPrime = true;
        
            for (int i=0; i < array.Length; i++)
            {
                for (int j=2; j < array[i]; j++)
                {
                    if (array[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }

                if (isPrime == true)
                {
                    Console.Write(array[i] + " ");
                }

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Constructor constructor_1 = new Constructor(4.0);
            Constructor constructor_2 = new Constructor('a');
            Constructor constructor_3 = new Constructor(9.2, 'b');
            Constructor constructor_4 = new Constructor(64.5, 8);
            Constructor constructor_5 = new Constructor(new int[] { 1, 2, 3, 4, 5, 7, 9, 12, 15, 31, 41, 52, 55, 64, 67, 70, 71 });

            Console.ReadKey();
        }
    }
}
