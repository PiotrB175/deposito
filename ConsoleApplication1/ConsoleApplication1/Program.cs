using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i,
                silnia = 1;
            Console.WriteLine("Podaj a");
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                silnia = 1;
                Console.WriteLine("Silnia z 0 wynosi: {0}", silnia);
            }
            else
            {
                for (i = 1; i <= a; i++)
                    silnia = silnia * i;
                Console.WriteLine("Silnia z {0} wynosi: {1}", a, silnia);
            }
            Console.ReadKey();
        }
    }
}
