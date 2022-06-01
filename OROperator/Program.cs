using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i != 2)
            {
                string username, password;

                Console.WriteLine("Enter username:");
                username = Console.ReadLine();

                Console.WriteLine("Enter password:");
                password = Console.ReadLine();
                i++;

                if (username != "admin" || password != "1234")
                {
                    Console.WriteLine("Access denied.");
                }
                else
                {
                    Console.WriteLine("Welcome");
                    break;
                }

                while (i == 2)
                {
                    string Username, Password;

                    Console.WriteLine("Enter username:");
                    Username = Console.ReadLine();

                    Console.WriteLine("Enter password:");
                    Password = Console.ReadLine();


                    if (Username != "admin" || Password != "1234")
                    {
                        Console.WriteLine("No attempts left");
                        break;
                    }
                    else if (Username == "admin" || Password != "1234")
                    {
                        Console.WriteLine("No attempts left");
                        break;
                    }
                    else if (Username != "admin" || Password == "1234")
                    {
                        Console.WriteLine("No attempts left");
                        break;
                    }
                }

            }
        }
    }
}