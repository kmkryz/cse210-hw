using System;

class Program
{
    static void Main(string[] args)
    {
        

        Assignment assignment1 = new Assignment("Joe Jonas", "Science");
        Console.WriteLine(assignment1.GetSummary());


        MathAssignment assignment2 = new MathAssignment("Enry Jones", "Math","342", "26-43");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());


        WritingAssignment assignment3 = new WritingAssignment("Marie Antoinette", "Writing", "The Cheery gulfs");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}