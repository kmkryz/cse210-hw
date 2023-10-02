using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)

    {
        Journal journal = new Journal();




        while (true){
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please enter your choice: ");
            Console.WriteLine();

            string choice = Console.ReadLine();


            switch (choice){

                case "1":
                    //add entry to journal
                    string _randomPrompt = Prompt.GetPrompt();
                    Console.WriteLine("Prompt: ");
                    Console.WriteLine(_randomPrompt);
                    Console.WriteLine();
                    
                    Entry _entry = Entry.GetEntry(_randomPrompt);

                    journal.AddEntry(_entry);



                    // Save journal to an automatic journal.csv file as backup
                    string filePath = "journal.csv";
                    journal.SaveToFile(filePath);
                    Console.WriteLine($"Journal saved to {filePath}");
                    Console.WriteLine();

                    break;

                case "2":
                    // Displays the journal
                    journal.DisplayJournal();
                    break;
                
                case "3":
                    //load entries from user file
                    Console.Write("Enter the filename to load the journal from: ");
                    string fileName = Console.ReadLine().Trim();
                    if (!string.IsNullOrWhiteSpace(fileName))
                    {
                        journal.LoadJournal(fileName);
                    }
                    break;

                case "4":
                    //save entries to user file or creates file if does not exist
                    journal.SaveJournal();
                    break;
                
                case "5":
                    //quit program
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid answer. Try again.");
                    break;

            }
        }























    }
}