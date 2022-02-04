using System;

namespace ConsoleApp.Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
            // 123456789 => 4 + 5 + 6

            Console.Write("9 reqemli ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 100000000 && a < 1000000000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 9 reqemli deyil !");
                return;
            }

            a /= 1000;

            a %= 1000;

            int left;
            int sum = 0;

            while (a > 0)
            {
                left = a % 10;  // 6
                a = (a - left) / 10; //45
                sum += left;
            }

            Console.WriteLine("Ededin ten ortasina dushen 3 reqemin cemi: " + sum);



            
            
        }
    }
}
