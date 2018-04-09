using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta siia minimaalne aastaarv");
            string a = Console.ReadLine();
            int min = int.Parse(a);


            Console.WriteLine("Sisesta siia maksimaalne aastaarv");
            string b = Console.ReadLine();
            int max = int.Parse(b);


            Console.WriteLine("Sisesta siia genereeritavate andmete hulk");
            string c = Console.ReadLine();
            int quantity = int.Parse(c);

            int d = 0;

            while (d < quantity)
            {
                Random arv = new Random();
                int number = arv.Next(min, max);

                Console.WriteLine(number);
                d = d + 1;

                System.Threading.Thread.Sleep(1000);
            }

            Console.ReadLine();
        }
    }
}