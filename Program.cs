using System;
//Namespace
namespace NumberGuesser
{
    //Program
    class MainClass
    {
        //Entry Point Method
        public static void Main(string[] args)
        {
            //heading for version and author name
            //set app variables
            //this is 0
            string appName = "Number Guesser";
            //this is 1
            string appVersion = "1.0.0";
            //this is 2
            string appAuthor = "Esteban Montantes";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //printing app name, version and author
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset console color after name and version is printed to screen
            Console.ResetColor();

            //Ask User for name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            //greet user with input
            Console.WriteLine("Hello {0}, get ready to guess a number!", inputName);

            //setting the correct number
            int correctNumber = 7;

            //setting guess variable
            int guessNumber = 0;

            //asking user for their number to guess
            Console.WriteLine("Guess a number between 1 and 10");

                

            //while guess is not correct
            while (guessNumber != correctNumber) {
                //Get user guess
                string inputGuess = Console.ReadLine();

                //Require numbers ONLY
                if (!int.TryParse(inputGuess, out guessNumber))
                {
                    //notify correct number
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    //guess is correct message
                    Console.WriteLine("Please use Real Numbers 1 through 10!");

                    //reset text color
                    Console.ResetColor();

                    //throws error message BUT can still RUN
                    continue;
                }

                //cast to integer and put into guess variable
                guessNumber = Int32.Parse(inputGuess);

                //notify wrong number
                if(guessNumber != correctNumber) {
                    //change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    //print wrong number message
                    Console.WriteLine("Wrong number, please try agaiin.");

                    //reset text color
                    Console.ResetColor();
                } // if loop end
            } //while loop end

            //notify correct number
            Console.ForegroundColor = ConsoleColor.Green;

            //guess is correct message
            Console.WriteLine("Beautiful number, that's correct!");

            //reset text color
            Console.ResetColor();
        } 
    } //main class end
}
