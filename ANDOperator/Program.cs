using System;

namespace ANDOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // username - admin, password - 1234
            
            int i = 0;



            while (i != 2)
            {

                string username, password;

                Console.WriteLine("Enter username:");
                username = Console.ReadLine();

                Console.WriteLine("Enter password:");
                password = Console.ReadLine();
                i++;

                if (username == "admin" && password == "1234")
                {
                    Console.WriteLine("Welcome!!");
                    break;

                }
                else
                {
                    Console.WriteLine("Access denied!!");


                }
            }
            while (i == 2)
            {
                string username, password;

                Console.WriteLine("Enter username:");
                username = Console.ReadLine();

                Console.WriteLine("Enter password:");
                password = Console.ReadLine();


                if (username != "admin" && password != "1234")
                {
                    Console.WriteLine("No attempts left");
                    break;
                }
                else if (username == "admin" && password != "1234")
                {
                    Console.WriteLine("No attempts left");
                    break;
                }
                else if (username != "admin" && password == "1234")
                {
                    Console.WriteLine("No attempts left");
                    break;
                }
            }


        }   
    }
}
