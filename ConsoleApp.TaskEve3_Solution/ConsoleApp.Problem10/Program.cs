using System;

namespace ConsoleApp.Problem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
            //sonra cut yerde dayanlarinda bir eded duzlet,
            //sonra onlari topla

            Console.Write("9 reqemli ededi daxil edin: ");  //123456789
            int a = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 100000000 && a < 1000000000;

            if (!isSuccess)
            {
                Console.WriteLine("Eded 9 reqemli deyil");
                return;
            }

            int sum = 0;
            int left;

            while (a > 0)
            {
                left = a % 10; // 9
                a = (a - left) / 10; // 12345678
                sum = sum * 10 + left; // 987654321
            }

            int left2;
            int counter = 1;
            int b = 0;
            
            
            while (sum > 0)
            {
                left2 = sum % 10; // 1
                sum = (sum - left2) / 10; // 98765432

                if (counter % 2 != 0)
                {
                    a = a * 10 + left2; //13579                    
                }

                else
                {
                    b = b * 10 + left2;
                }

                counter++;
            }

            Console.WriteLine("Tek yerde dayanlardan ibaret eded: " + a);
            Console.WriteLine("--------");
            Console.WriteLine("Cut yerde dayanlardan ibaret eded: " + b);

            int c = a + b;

            Console.WriteLine("Ededlerin cemi: " + c);
            
            
            
            





        }
    }
}
