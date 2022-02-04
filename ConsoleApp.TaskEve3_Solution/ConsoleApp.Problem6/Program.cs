using System;

namespace ConsoleApp.Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et
            // example: 12345678 => 234567

            Console.Write("8 reqemli ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 10000000 && a < 100000000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 8 reqemli deyil !");
                return;
            }

            a %= 10000000; // 2345678

            int lastNumber = a % 10;

            a = (a - lastNumber) /10;

            Console.WriteLine("Ededin ilk ve ededleri legv edildikde alinan cavab: " + a);
        }
    }
}
