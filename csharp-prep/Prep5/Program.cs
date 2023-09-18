using System;


class Program
{
  
   

        static void Main(string[] args)
        {
            DisplayWelcome();

            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(userName, squaredNumber);

        }



        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }



        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            return name;
        }



        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }



        static int SquareNumber(int userNumber)
        {
            int square = userNumber * userNumber;
            
            return square;
        }


        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
    
}