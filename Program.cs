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
            Console.WriteLine("Podaj liczbę 1");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbę 2");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.Write("Liczby parzyste:");
            for(int i = liczba1; i <= liczba2; i++)
                if(i % 2 == 0)
                {
                    Console.Write(i + ",");
                }
            Console.ReadKey();
        }
        
    }
}
