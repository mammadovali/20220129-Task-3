using System;

namespace ConsoleApp.Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap.
            // example: 123600= 1+2+3

            Console.Write("6 reqemli ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 100000 && a < 1000000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 6 reqemli deyil !");
                return;
            }

            a /= 1000; // 123
            int left;
            int sum = 0;

            while (a > 0)
            {
                left = a % 10;
                a = (a - left) / 10; //12
                sum += left;            
            }

            Console.WriteLine("Ededin ilk 3 reqeminin cemi: " + sum);


        }
    }
}
