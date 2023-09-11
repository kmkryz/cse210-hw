using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float number = int.Parse(userInput);

        string letterGrade= "";

        if (number >= 90)
        {
            letterGrade="A";

        }
        else if (number >= 80)
        {
            letterGrade="B";
        }
        else if (number >= 70)
        {
            letterGrade="C";
        }
        else if (number >= 60)
        {
            letterGrade="D";
        }
        else 
        {
            letterGrade="F";
        }
    
        Console.WriteLine($"Your letter grade for this course: {letterGrade}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("I'm sorry you did not pass, better luck next time!");
        }
}
}