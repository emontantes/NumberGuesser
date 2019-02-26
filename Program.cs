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
            string input = Console.ReadLine();

            //greet user with input
            Console.WriteLine("Hello {0}, get ready to guess a number!", input);
        } 
    }
}
