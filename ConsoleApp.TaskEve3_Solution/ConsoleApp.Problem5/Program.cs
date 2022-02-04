using System;

namespace ConsoleApp.Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
            // example:  123456 => 234561

            Console.Write("6 reqemli ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 100000 && a < 1000000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 6 reqemli deyil");
                return;
            }

            int firstNumber = a / 100000; //1

            a %= 100000;
            a = a * 10 + firstNumber;

            Console.WriteLine("Ilk reqemi ededin sonuna elave etdikde alinan cavab: " + a);
            




        }
    }
}
