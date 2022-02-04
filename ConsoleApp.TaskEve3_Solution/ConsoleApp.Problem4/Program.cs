using System;

namespace ConsoleApp.Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati          

            Console.Write("5 reqemli ededi daxil edin: "); // 23456
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 10000 && a < 100000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 5 reqemli deyil !");
                return;
            }

            int b = a % 10; //6 

            a /= 10000; // 2

            int c = (a + b) * (a + b); //8*8

            Console.WriteLine("Ededin ilk ve son reqeminin ceminin kvadrati: " + c);
        }
    }
}
