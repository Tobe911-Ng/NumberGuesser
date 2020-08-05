using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while(true)
            {
                //Set correct Number
                //int correctNumber = 7;

                //Create a new Random Object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Guess Number
                int guess = 0;

                //Ask for number
                Console.WriteLine("Guess a number between 0 and 9");

                //While Guess isn't correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error: Not a number!");
                        Console.ResetColor();
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, try again");
                        Console.ResetColor();
                    }
                }

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("You are correct");
                Console.ResetColor();

                //Play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

                Console.ReadLine();
         
            }
            
        }

        static void GetAppInfo(){
            // Set app var
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Tobenna Etiaba";


            //Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            //App Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text Color
            Console.ResetColor();
        }

        //Get Info
        static void GreetUser(){
            //Ask User's name
            Console.WriteLine("What is your name?");

            //Get User's Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game....", inputName);
        }
        
    }
}
