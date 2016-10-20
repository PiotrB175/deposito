using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, i=0;
            Console.WriteLine("Podaj a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = double.Parse(Console.ReadLine());
            for(i=a; i<=b; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        
    }
}
