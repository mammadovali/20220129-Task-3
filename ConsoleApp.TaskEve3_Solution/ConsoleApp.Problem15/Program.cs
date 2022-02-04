using System;

namespace ConsoleApp.Problem15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
            // 3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesinin kvadratini tap.
            // Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededi gel.
            // Cavabdan 7 reqemli ededin son 5 reqemini cix.
            // Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
            // Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
            // Cavabin axirina 11 artir.
            // Sonra 7 reqemli ededin tek yerde dayanan reqemlerinden alinan ededi cix.
            // Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.

            Console.Write("Birinci 3 reqemli ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 3 reqemli ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Birinci 6 reqemli ededi daxil edin: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 6 reqemli ededi daxil edin: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.Write("7 reqemli ededi daxil edin: ");
            int e = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 100 && a < 1000 & b >= 100 && b < 1000;
            bool isSuccess2 = c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000;
            bool isSuccess3 = e >= 1000000 && e < 10000000;

            if (!(isSuccess && isSuccess2 && isSuccess3))
            {
                Console.WriteLine("Daxil edilen ededler shertlere uygun deyil !");
                return;
            }

            int sum3 = a + b;
            Console.WriteLine("3 reqemli ededlerin cemi: " + sum3);

            sum3 = sum3 % 100; // axirdan 2 reqem
            sum3 *= sum3;
            Console.WriteLine("Axirdan iki reqemin kvadrati: " + sum3);

            a = a * 1000 + b;
            int newSum = sum3 + a;
            Console.WriteLine("Alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan alinan eded gelindi: " + newSum);
            Console.WriteLine("--------");

            int last5 = e % 100000; // son 5 reqem
            int sub = newSum - last5;
            Console.WriteLine("Cavabdan 7 reqemli ededin son 5 reqemi cixildi: " + sub);
            Console.WriteLine("--------");

            int sum6 = c + d; //6 reqemlilerin cemi
            Console.WriteLine("6 reqemlilerin cemi: " + sum6);
            Console.WriteLine("--------");
            sum6 %= 1000; // son 3 eded

            int newSum2 = sub + sum6;
            Console.WriteLine("Bir onceki alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene reqemi gelindi:" + newSum2);

            int digitSum = 0;
            int left;
            int eSame = e; // to use in further steps

            while (e > 0)
            {
                left = e % 10; // 7
                e = (e - left) / 10; // 123456
                digitSum += left; // 1+2+3+5+6+7 = 28
            }
            Console.WriteLine("7 reqemli ededin reqemleri cemi: " + digitSum);
            int left2;
            int reverse = 0;

            while (digitSum > 0)
            {
                left2 = digitSum % 10; // 8
                digitSum = (digitSum - left2) / 10; // 2
                reverse = reverse * 10 + left2;
            }
            Console.WriteLine("7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan eded: " + reverse);
            int summation = newSum2 + reverse;
            Console.WriteLine("Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavab gelindi: " + summation);
            summation = summation * 100 + 11;

            Console.WriteLine("Cavabin axirina 11 artirildi: " + summation);

            int left3;
            int summ = 0;

            while (eSame > 0)
            {
                left3 = eSame % 10; //7
                eSame = (eSame - left3) / 10; // 123456
                summ = summ * 10 + left3; //7654321
            }

            int left4;
            int summ2 = 0;
            int counter = 1;

            while (summ > 0)
            {
                left4 = summ % 10; // 1
                summ = (summ - left4) / 10; //765432

                if (counter % 2 != 0)
                {
                    summ2 = summ2 * 10 + left4;
                }

                counter++;
            }
            Console.WriteLine("7 reqemli ededin tek yerde dayanan reqemleri: " + summ2);
            Console.WriteLine("--------");

            double sub2 = summ2 - summation;
            Console.WriteLine("7 reqemli ededin tek yerde dayanan reqemlerinden alinan eded cixildi: " + sub2); 
            

            double lastNumber = sub2 % 10;           
            sub2 = (sub2 - lastNumber) / 10;            
            sub2 = sub2 * 100 - 88;            
            sub2 = sub2 * 10 + lastNumber;
          
            Console.WriteLine("Cavabin axirdan II reqemi ile axirinci reqeminin arasina 88 elave edildi: " + sub2);


        }
    }
}
