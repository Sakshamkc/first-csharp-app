using System;

namespace Guessing_number
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfo();
            GreetUser();
            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Enter the guess number between 1 and 10");


                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please try an actual Number");
                        continue;
                    }

                    guess = Int32.Parse(input);
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Sorry you guessed it wrong,Please try it again");
                    }

                   
                }
                PrintColorMessage(ConsoleColor.Yellow, "Congratulation,You guessed it right");

                Console.WriteLine("Wanna play again? [Y] or [N]");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }
        static void GetInfo()
        {
            string app_name = "Guessing Number";
            string app_version = "1.9.8.7";
            string app_author = "Saksham kc";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", app_name, app_version, app_author);
            Console.ResetColor();
        }
        static void GreetUser()
        {
            Console.WriteLine("Enter your name");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0},lets play a game........", inputName);
        }
        static void PrintColorMessage(ConsoleColor color , string Message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Message);
            Console.ResetColor();
        }
    }
}
