using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x=0, y=0, delta;
            Console.WriteLine("Podaj a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            c = double.Parse(Console.ReadLine());
            if (a == 0) { Console.WriteLine("To nie jest f kwadratowa"); }
            else { delta = (b * b) - 4 * a * c;
                if (delta > 0)
                {
                    x = (-b - Math.Sqrt(delta)) / (2 * a);
                    y = (-b + Math.Sqrt(delta)) / (2 * a);
                }
                if (delta < 0) { Console.WriteLine("Brak m zerowych"); }
                if (delta == 0) { x = (-b) / (2 * a);
                }
            }
            Console.WriteLine("miejsce zerowe fuinkcji {0}*x^2+{1}*x+{2}= {3} lub {4}", a,b,c,x,y);
            Console.ReadKey();

        }
    }
}
