using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //create random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //initializes guess out of range of magic number
        int guess = 0;

        //initializes number of attempts
        int attempts = 0;

        Console.WriteLine($"What is the magic number? {magicNumber}");

        while (guess != magicNumber)
        {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                attempts++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("higher");
                }
                else
                {
                    Console.WriteLine($"Congrats! You guessed the magic number {magicNumber} in {attempts} attempts!");
                }

        }



    }


 
}
