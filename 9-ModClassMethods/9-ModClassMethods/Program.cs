using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ModClassMethods
{
    class Program
    {
        public static bool IsItPalindrom(string wordToCheck)
        {
            if (String.IsNullOrEmpty(wordToCheck))
            {
                return false;
            }

            wordToCheck = wordToCheck.Replace(" ", "").ToLower();
            int wordLength = wordToCheck.Length;

            for (int i=0; i < wordLength / 2; i++)
            {
                if (wordToCheck[i] != wordToCheck[wordLength - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Nazwa pliku z palindromem: ");
            string fileName = Console.ReadLine();
            fileName += ".txt";

            try
            {
                using (StreamReader read = new StreamReader(fileName))
                {
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        if (IsItPalindrom(line))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            } catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadKey();
        }
    }
}
