using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1=0, x2=0;
            Console.WriteLine("Program oblicza pierwiastki równania a*x^2+b*x+c=0");
            Console.WriteLine("Podaj a");
            a = double.Parse(Console.ReadLine());
            
            
            if (a == 0)
            {
                Console.WriteLine("Równanie nie jest funkcją kwadratową");
            }
            else
            {
                Console.WriteLine("Podaj b");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c");
                c = double.Parse(Console.ReadLine());

                delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("Równanie nie ma pierwiastków w zbiorze liczb rzeczywistych");
                }
                else if (delta == 0)
                {
                    x1 = x2;
                    x1 = -b / 2 * a;
                    Console.WriteLine("Równanie ma jeden pierwiastek 'podwójny' równy: x=[0]", x1);
                }
                else if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta) / 2 * a);
                    x2 = (-b + Math.Sqrt(delta) / 2 * a);
                    Console.WriteLine("Równanie ma dwa pierwiastki: x1={0}, x2={0} ", x1, x2);
                }
                
            }
            Console.ReadKey();
        }
    }
}
