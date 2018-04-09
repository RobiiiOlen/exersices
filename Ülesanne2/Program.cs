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

            // Ülesanne 2
            Console.WriteLine("Sisesta lauseid, kus on kasutatud järgmisi nimesi:");

            string[] nimed = new string[10] { "kaur", "mattias", "kristel", "heleri", "trevor",
                                               "kristjan", "kelli", "kevin", "maarika", "laura" };

            {
                int indeks = 0;
                while (indeks < nimed.Length)
                {

                    string nimi = nimed[indeks];

                    string Suurtäht = char.ToUpper(nimi[0]) + nimi.Substring(1).ToLower();

                    Console.Write(Suurtäht);

                    indeks += 1;

                    if (indeks < nimed.Length)
                    {

                        Console.Write(", ");
                    }


                    Console.ReadLine();
                }
            }
        }
    }
}