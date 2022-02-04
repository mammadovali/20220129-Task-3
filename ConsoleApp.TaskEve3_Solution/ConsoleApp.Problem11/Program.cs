using System;

namespace ConsoleApp.Problem11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8 reqemli ededin reqemlerini iki -iki qruplashdir.
            // Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
            //Sonra cavabin ozunden onun 18 % ni cix;

            Console.Write("8 reqemli ededi daxil edin: "); // 12345678
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 10000000 && a < 100000000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 8 reqemli deyil !");
                return;
            }

            int left;
            int[] mass = new int[4];
            int counter = 3;
            
            while (a > 0)
            {
                left = a % 100; // 78
                a = (a - left) / 100; // 123456
                mass[counter] = left;
                                              
              
                counter--;  // her bir ikili qrup massivde yerleshdirildi                
            }           
            
            // mass[0] = 12
            // mass[1] = 34
            // mass[2] = 56
            // mass[3] = 78

            double sum = 0;           
            for (int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];
                Console.WriteLine($"{i + 1}. qrup: " + mass[i]);
            }

            Console.WriteLine("--------");
            Console.WriteLine("Qruplarin cemi: " + sum); //180

            sum = sum * 100 + 99; // 18099

            Console.WriteLine("Alinan cavabin axirina 99 elave edildi: " + sum);

            double perc = (sum * 18) / 100;
            Console.WriteLine("Cavabin 18% i: " + perc);

            sum -= perc;

            Console.WriteLine("Cavabin ozunden onun 18% i cixildi: " + sum);














        }            
          
    }
}
