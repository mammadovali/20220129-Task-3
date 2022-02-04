using System;

namespace ConsoleApp.Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
            // example: 1234 => 843218

            Console.Write("4 reqemli ededi daxil edin: "); //1234
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 1000 && a < 10000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 4 reqemli deyil! ");
                return;
            }

            int left;
            int newNumber = 0;

            while (a > 0)
            {
                left = a % 10; // 4
                a = (a - left) / 10; //123
                newNumber = newNumber * 10 + left;
            }

            Console.WriteLine("Eded tersine duzuldu: " + newNumber);
            Console.WriteLine("--------");

            newNumber += 80000;
            newNumber = newNumber * 10 + 8;

            Console.WriteLine("Yeni ededin evveline ve sonuna 8 reqemi artirildi: " + newNumber);


        }
    }
}
