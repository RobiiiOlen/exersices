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
            //see programm jätab lauses
            //iga sõna esimese ja viimase
            //t'he paigale, kuid muudab 
            //sõna sees olevate tähtede järjekorda
            //Console.WriteLine("must koer hüppas üle suure valge aia");


            
            string input = "kanamuna";
            string output = "";
            int ranIndex = 0;
            List<int> indexes = new List<int>();
            char[] split = input.ToCharArray();
            Random ran = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                ranIndex = ran.Next(0, input.Length);

                if (!indexes.Contains(ranIndex))
                {
                    indexes.Add(ranIndex);
                }
                else
                {
                    i--;
                }
            }

            foreach (int value in indexes)
            {
                output += split[value];
            }

            Console.WriteLine(output);
            Console.ReadLine();














            Console.ReadLine();
        }
    }
}
