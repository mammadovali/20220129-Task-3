using System;

namespace ConsoleApp.Problem14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            // 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            //Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            //Alinan cavabdan cix 7 reqemli ededin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            //Neticenin 60 % tap.Cavabin axirina 60 artir.
            //Neticeden 18 % cix.

            Console.Write("Birinci 6 reqemli ededi daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci 6 reqemli ededi daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("7 reqemli ededi daxil edin: "); 
            int c = Convert.ToInt32(Console.ReadLine());

            bool isSuccess = a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000;
            bool isSuccess2 = c >= 1000000 && c < 10000000;

            if (!(isSuccess && isSuccess2))
            {
                Console.WriteLine("Daxil edilen ededler shertlere uygun deyil !");
                return;
            }

            int[] mass = {a, b };
            int[] first_Three = new int[2];
            int counter = 0;
            foreach (var item in mass)
            {
                int left = item % 1000;
                int firstThree = (item - left) / 1000;
                first_Three[counter] = firstThree;

                counter++;
            }

            

            int sum = 0;

            for (int i = 0; i < first_Three.Length; i++)
            {
                sum += first_Three[i];
                Console.WriteLine($"{i + 1} ci 6 reqemli ededin ilk 3 reqeminden alinan eded: " + first_Three[i]);
            }

            Console.WriteLine("--------");
            Console.WriteLine("Her iki 6 reqemli ededin ilk 3 reqeminden alinan ededlerin cemi: " + sum);

            int lastFour = c % 10000; 
            Console.WriteLine("7 reqemli ededin son 4 reqeminden alinan eded: " + lastFour);
            Console.WriteLine("--------");

            int summation = sum + lastFour;
            Console.WriteLine("Son iki neticenin cemi: " + summation);
            Console.WriteLine("--------");

            int left2 = c % 10000; // son 4 reqem
            c = (c - left2) / 10000; //  ilk 3 reqem

            int multiple = 1;
            int left3;

            while (c > 0)
            {
                left3 = c % 10;
                c = (c - left3) / 10;
                multiple *= left3;
            }

            Console.WriteLine("7 reqemli ededin ilk 3 reqeminin hasili: " + multiple);
            Console.WriteLine("--------");

            int subtract = summation - multiple;
            Console.WriteLine("Bir onceki netice ile 7 reqemli ededin ilk 3 reqeminin hasilinin ferqi: " + subtract);
            Console.WriteLine("--------");

            int perc60 = (subtract * 60) / 100;
            double percent60 = perc60 * 100 + 60;

            Console.WriteLine("Neticenin 60% faizi tapildi ve cavabin axirina 60 ededi elave edildi: " + percent60);

            double perc18 = (percent60 * 18) / 100;
            Console.WriteLine($"Yekun cavabdan ozunun 18% i cixildi: {percent60 - perc18}");

          
        }
    }
}
