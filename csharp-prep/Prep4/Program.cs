using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int total = 0;
        

        {   //initialize list
            List<int> numbersList = new List<int>();

            int newNumber=-1;


            while (newNumber != 0)

            {
                Console.Write("Enter number: ");
                newNumber = int.Parse(Console.ReadLine());

                if (newNumber != 0)
                {
                    numbersList.Add(newNumber);
                    total+=newNumber;
                }


            }


            //core requirements: total, average, max number
            Console.WriteLine($"The sum is: {total}");

            Console.WriteLine($"The average is: {numbersList.Average()}");

            Console.WriteLine($"The Largest number: {numbersList.Max()}");

            //sorted list stretch
            var sortedList = numbersList.OrderByDescending(num => num).ToList();
            Console.WriteLine("Sorted List: ");
            foreach (int num in sortedList)
            {
                Console.WriteLine(num);
            }

        }



    }
}