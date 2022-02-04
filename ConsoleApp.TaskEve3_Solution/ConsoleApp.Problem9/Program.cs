using System;

namespace ConsoleApp.Problem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9 reqemli ededin tek yerde dayananlardan bir eded duzlet:
            // 132346389 = 12439

            Console.Write("9 reqemli ededi daxil edin: "); //123456789
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
                left = a % 10; //9
                a = (a - left) / 10; //12345678
                sum = sum * 10 + left; // eded tersine cevrildi: 987654321
            }
          
            int counter = 1;
            int left2;          
            
            while (sum > 0)
            {                              
              left2 = sum % 10; //1
              sum = (sum - left2) / 10; //98765432
            
                if (counter % 2 != 0)
                {
                    a = a * 10 + left2;
                }   
                
                counter++;             
            }
            
            Console.WriteLine("Ededin tek yerde dayanan reqemlerinden ibaret eded: " + a);





        }
    }
}
