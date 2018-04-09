using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nimed = new List<string>();
            Console.WriteLine("Sisesta nimi suure algustähega!");
            while (true)
            {

                Console.Write("-->");
                string input = Console.ReadLine();

                nimed.Add(input);

                if (input == "-1")
                {
                    break;
                }
            }

            string[] nime_arr = nimed.ToArray();

            foreach (var value in nimed)
            {
                Console.Write($" {value}");
            }

            Console.ReadLine();
        }
    }
}

