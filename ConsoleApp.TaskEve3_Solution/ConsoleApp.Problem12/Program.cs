using System;

namespace ConsoleApp.Problem12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 dene 5 reqemli eded daxil et.
            // I ededin reqemleri ceminin ustune
            // II ededin reqemleri hasilini gel.
            // Neticenin axirina I ededin en axiinci reqemini artir.

            Console.Write("Birinci 5 reqemli ededi daxil edin: ");  //12345
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 5 reqemli ededi daxil edin: "); // 56789
            int b = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 10000 && a < 100000 && b >= 10000 && b < 100000;

            if (!isSuccess)
            {
                Console.WriteLine("Daxil edilen eded ve ya ededler 5 reqemli deyil !");
                return;
            }

            int sum = 0;
            int left;
            int lastNumber = a % 10; //5

            while (a > 0)
            {
                left = a % 10; // 5
                a = (a - left) / 10; // 1234
                sum += left;
            }

            Console.WriteLine("Birinci ededin reqemleri cemi: " + sum);
            Console.WriteLine("--------");

            int multip = 1;
            int left2;

            while (b > 0)
            {
                left2 = b % 10; // 9
                b = (b - left2) / 10; // 5678
                multip *= left2;
            }

            Console.WriteLine("Ikinci ededin reqemleri cemi: " + multip);
            Console.WriteLine("--------");

            int newNumber = sum + multip;
            Console.WriteLine("Birinci ededin reqemleri cemi + Ikinci ededin reqemleri hasili: " + newNumber);
            Console.WriteLine("--------");

            newNumber = newNumber * 10 + lastNumber;
            Console.WriteLine("Neticenin axirina birinci ededin sonuncu reqemi elave olundu: " + newNumber);

        }
    }
}
