using System;

namespace Discount
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What amount of money did you spent in our store?");
            Console.WriteLine("Enter amount to know your discount for your next purchase: ");
            int totalCost = Convert.ToInt32(Console.ReadLine());

            if (totalCost < 10)
            {
                Console.WriteLine("Sorry, but its not enough to get discount.");
            }
            else if (totalCost >= 10 && totalCost <= 20)
            {
                Console.WriteLine("Next time you will get 1 euro discount!!");
            }
            else if (totalCost > 20 && totalCost <= 50)
            {
                Console.WriteLine("Next time you will get 5 euro discount!!");
            }
            else if (totalCost > 50 && totalCost <= 100)
            {
                Console.WriteLine("Next time you will get 10 euro discount!!!");
            }
            else
            {
                Console.WriteLine("Next time you will get 15 euro discount!!!");
            }

            Console.WriteLine("Have a nice day!");
        }
    }
}
