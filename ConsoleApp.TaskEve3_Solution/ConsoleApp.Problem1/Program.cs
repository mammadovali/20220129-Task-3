using System;

namespace ConsoleApp.Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  verilmish 4 reqemli ededin reqemlerinin cemini tap

            Console.Write("4 reqemli ededi daxil edin: "); //1234
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 1000 && a < 10000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 4 reqemli deyil! ");
                return;
            }

            int sum = 0;
            int left; 

            while (a > 0)
            {
                left = a % 10; // 4
                a = (a - left) / 10; //123
                sum += left;
            }

            Console.WriteLine("Ededin reqemleri cemi: " + sum);


        }
    }
}
