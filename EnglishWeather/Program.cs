using System;

namespace EnglishWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemp;
            Console.WriteLine("Enter the temperature!");
            currentTemp = Convert.ToInt32(Console.ReadLine());


            if(currentTemp < 0)
            {
                Console.WriteLine("Freezing cold");
            }
            else if(currentTemp >= 0 && currentTemp <= 10)
            {
                Console.WriteLine("Very cold");
            }
            else if (currentTemp >= 10 && currentTemp <= 20)
            {
                Console.WriteLine("Cold");
            }
            else if (currentTemp >= 20 && currentTemp <= 30)
            {
                Console.WriteLine("Warm");
            }
            else if (currentTemp >= 30 && currentTemp <= 35)
            {
                Console.WriteLine("Hot");
            }
            if (currentTemp > 35)
            {
                Console.WriteLine("Boiling Hot");
            }
        }
    }
}
