using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InterfaceNWW
{
    public interface Variables
    {
        int A { get; set; }
        int B { get; set; }

        int NWW { get; set; }
    }

    public class Numbers : Variables
    {
        private int a, b, nww;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public int NWW
        {
            get { return nww; }
            set { nww = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers();

            Console.Write("Podaj pierwsza liczbe: ");
            string num1 = Console.ReadLine();
            num.A = Convert.ToInt32(num1);

            Console.Write("Podaj druga liczbe: ");
            string num2 = Console.ReadLine();
            num.B = Convert.ToInt32(num2);

            int NWW(int a, int b)
            {
                if(a < b)
                {
                    return NWW(b, a);
                }
                else
                {
                    int result = a;
                    while(result%b != 0)
                    {
                        result += a;
                    }

                    return num.NWW = result;
                }
            }

            NWW(num.A, num.B);

            Console.WriteLine("NWW wynosi: {0}", num.NWW);
            Console.ReadKey();
        }
    }
}
