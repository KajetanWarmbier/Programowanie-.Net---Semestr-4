using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_NewtonRaphsonNested
{
    public class Newton
    {
        public class Nested
        {
            public double newtonRaphson(double x)
            {
                double epsilon = 0.00001;
                double h = x / 2;

                while( Math.Abs(h - (x/h)) >= epsilon)
                {
                    h = (h + (x / h)) / 2;
                    if (Math.Sqrt(h) == 2)
                    {
                        return h;
                    }
                }
                return h;
            }
        }

        public void result()
        {
            Nested nes = new Nested();
            Console.Write("Podaj liczbę: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(nes.newtonRaphson(number));

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Newton newton = new Newton();
            newton.result();
            Console.ReadKey();
        }
    }
}
