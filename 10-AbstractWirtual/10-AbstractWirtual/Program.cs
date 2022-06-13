using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AbstractWirtual
{
    public abstract class First
    {
        public abstract void f();

        public virtual String r()
        {
            return "Finished";
        }
    }

    public abstract class Second : First
    {
        public override void f()
        {
            Console.WriteLine("Second f()");
        }

        public override string r()
        {
            return "End.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            void putItOn(ref string str, char help, int count)
            {
                if (count > 0)
                {
                    str += help;
                }

                if (count > 1)
                {
                    str += count.ToString();
                }
            }

            string compression(string t)
            {
                string result = "";
                int count = 0;
                char help = t[0];

                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] == help)
                    {
                        count++;
                    }
                    else
                    {
                        putItOn(ref result, help, count);
                        help = t[i];
                        count = 1;
                    }
                }
                putItOn(ref result, help, count);
                return result;
            }

            Console.WriteLine(compression("Unnniiiiwwerrrsyyyttttteeeeet"));
            Console.WriteLine(compression("Gddddaansssskkii"));

            Console.ReadKey();
        }
    }
}


    

