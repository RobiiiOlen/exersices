using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            
            double sum = 0;

            Console.WriteLine("-----------------------------------");
            while (true)           
            {
                Console.Write("Enter price of food item [-1 to quit]: ");
                double input = double.Parse(Console.ReadLine());
                

                if (input == -1) 
                    break;
                
                sum = sum + input;
                
            }

            
            
            Console.Write("$Subtotal: ");







            Console.ReadLine();
        }
    }
}
