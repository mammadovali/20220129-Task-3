using System;

namespace ConsoleApp.Problem13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 dene 5 reqemli eded var.
            // Her bir  ededin ilk ve son reqemlerinden 1 eded duzlet. Alinan neticeleri topla.
            // Yekunda alinan cavabin 50 % -ni hemin ededin uzerine gel.

            Console.Write("Birinci 5 reqemli ededi daxil edin: ");  
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 5 reqemli ededi daxil edin: ");  
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ucuncu 5 reqemli ededi daxil edin: ");  
            int c = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 10000 && a < 100000;
            bool isSuccess2 = b >= 10000 && b < 100000;
            bool isSuccess3 = c >= 10000 && c < 100000;

            if (!(isSuccess && isSuccess2 && isSuccess3))
            {
                Console.WriteLine("Daxil edilen ededlerin hamisi 5 reqemli deyil !");
                return;
            }

            int[] mass = { a, b, c };
            int[] newNumber = new int[3];
            int lastNumber;
            int firstNumber;
            int union;
            int counter = 0;

            foreach (var item in mass)
            {
                lastNumber = item % 10;
                firstNumber = item / 10000;
                union = firstNumber * 10 + lastNumber;

                newNumber[counter] = union;
                counter++;
            }

            double sum = 0;

            for (int i = 0; i < newNumber.Length; i++)
            {
                Console.WriteLine($"{i + 1}. eded: " + newNumber[i]);
                sum += newNumber[i];
            }

            Console.WriteLine("Alinan neticelerin cemi: " + sum);

            double half = (sum * 50) / 100;
            Console.WriteLine("Alinan cavabin 50% i: " + half);
            Console.WriteLine("--------");

            sum += half;
            Console.WriteLine("Alinan cavabin 50% i ededin uzerine gelindi: " + sum);


         
        }
    }
}
