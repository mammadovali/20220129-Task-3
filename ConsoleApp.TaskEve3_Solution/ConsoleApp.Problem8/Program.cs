using System;

namespace ConsoleApp.Problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap  

            Console.Write("Ededi daxil edin: "); // 123456
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 100;

            if (!isSuccess)
            {
                Console.WriteLine("Eded en azi 3 reqemli olmalidir !");
                return;
            }          

            int b = a % 10; // sonuncu reqem (6)

            int c = a % 1000; //son 3 reqem (456)

            c /= 100; //4

            int sum = b + c;

            Console.WriteLine("Ededin axirdan 3-cu reqemi ile sonuncu reqeminin cemi: " + sum);



          
        }
    }
}
