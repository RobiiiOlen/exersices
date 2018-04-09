using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ülesanne4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee massiiv kus on 30 erinevat timestampi vahemikus 1940-2010


            {

                DateTime[] array = new DateTime[11];

                DateTime now = DateTime.Now;

                for (int i = 1; i <= 10; i++)
                {
                    Random rnd = new Random();
                    int day = rnd.Next(1, 31);
                    int Mon = rnd.Next(1, 12);
                    int yea = rnd.Next(1940, 2010);
                    int hour = rnd.Next(0, 23);
                    int min = rnd.Next(0, 59);
                    int sec = rnd.Next(0, 59);

                    var date = new DateTime(yea, Mon, day, hour, min, sec);
                    Console.WriteLine(date);

                    array[i] = date;
                    System.Threading.Thread.Sleep(500);





                    //  arvuta vanused
                }
                
                 int age1 = now.Year - array[1].Year;
                 int age2 = now.Year - array[2].Year;
                 int age3 = now.Year - array[3].Year;
                 int age4 = now.Year - array[4].Year;
                 int age5 = now.Year - array[5].Year;
                 int age6 = now.Year - array[6].Year;
                 int age7 = now.Year - array[7].Year;
                 int age8 = now.Year - array[8].Year;
                 int age9 = now.Year - array[9].Year;
                 int age10 = now.Year - array[10].Year;
             
             
                int[] vanused = new int[] {
                 age1 = now.Year - array[1].Year,
                 age2 = now.Year - array[2].Year,
                 age3 = now.Year - array[3].Year,
                 age4 = now.Year - array[4].Year,
                 age5 = now.Year - array[5].Year,
                 age6 = now.Year - array[6].Year,
                 age7 = now.Year - array[7].Year,
                 age8 = now.Year - array[8].Year,
                 age9 = now.Year - array[9].Year,
                 age10 = now.Year - array[10].Year
                };

                
                




                //Leia massiivist maksimaalne vanus
                int maxvanus = vanused.Max();
                

                Console.Write($"Maksimaalne vanus on:{maxvanus} ");
                Console.WriteLine();




                //harju keskmine

                int avg=((age1+age2+age3+age4+age5+age6+age7+age8+age9+age10)/ 10);
                
                Console.Write($"Keskmine vanus on:{avg}");
                Console.WriteLine();




                //minimaalne vanus

                int minvanus = vanused.Min();
                Console.Write($"Minimaalne vanus on:{minvanus}");
                Console.WriteLine();




                //mis kuul on rohkem sündinuid

                int kuu1, kuu2, kuu3, kuu4, kuu5, kuu6, kuu7, kuu8, kuu9, kuu10, kuu11, kuu12;



                //kontrolli mis numbrit esineb rohkem(kuu) ja jäta meelde


                //lisada 1-12 stringid mis kuu on mis number


                //siduda kuud ja nimed omavahel
            /*    string[] monthNames =
                    System.Globalization.CultureInfo.CurrentCulture
                   .DateTimeFormat.MonthGenitiveNames;
        */


                //väljastada kuu mida esineb rohkem



                Console.Write("Kõige rohkem sünnipäevi on ");
                Console.WriteLine();




                //terve massiiv kasvavalt kuvatud
                Array.Sort(array);
                foreach (var str in array)
                {
                    Console.WriteLine(str.ToString());
                }
                

                    Console.WriteLine($"Massiiv kasvavas järjekorras:");
                Console.WriteLine();





                Console.ReadLine();
            }
        

        
        }
    }
}
