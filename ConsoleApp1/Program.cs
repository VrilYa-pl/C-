using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Wprowadz liczbe z zakresu 1-6");
            try
            {
                x = int.Parse(Console.ReadLine());
                if (x > 6)
                    Console.WriteLine("Wprowadziles liczbe większą niz 6");

                else
                {
                    //x = 31;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    //  Console.WriteLine("Hello World");
                    Console.WriteLine("Wprowadziles liczbe: {0}", x);
                }
            }
            catch (FormatException fEx)
            {
                Console.WriteLine(fEx.Message);
            }

            Console.WriteLine("Wcisnij dowolny przycisk aby zamknac program");
            Console.ReadKey();
           

            }
    }
}
