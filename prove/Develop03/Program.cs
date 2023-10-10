using System;


class Program
{
    static void Main(string[] args)
    {
        // Reference reference = new Reference("Proverbs 3:5-6");
        // Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths.");


        Console.WriteLine("Enter the scripture reference (e.g., 'Proverbs 3:5-6'):");
        string referenceInput = Console.ReadLine();

        Reference reference;
        try
        {
            reference = new Reference(referenceInput);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid scripture reference format.");
            return;
        }

        Console.WriteLine("Enter the scripture text:");
        string scriptureText = Console.ReadLine();

        Scripture scripture = new Scripture(reference, scriptureText);
        

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine($"Scripture ({reference}): {scriptureText}");
        Console.WriteLine("Press Enter to hide words in the scripture, or type 'quit' to exit.");
        Console.WriteLine();

        int _wordsToHide = 1;
        int _hiddenCount = 0;
        Random random = new Random();

        while (_hiddenCount<scripture._wordCount){

            string userInput = Console.ReadLine().ToLower();

            if (userInput == "quit"){

                break;
            }

            else if (userInput == ""){
                Console.Clear();
                Console.Write($"Scripture: {reference} ");
                scripture.HideWords(random);
                // _hiddenCount = scripture._hiddenWordCount;
                _hiddenCount += _wordsToHide;

                Console.WriteLine("\n Press Enter to hide more words or type 'quit' to exit.");
                _wordsToHide++; // Increase the number of words to hide
                Console.WriteLine();
            }

            else{
                Console.WriteLine("Invalid input. Press enter to continue to type 'quit' to end the program.");

            };

        }
        if (_hiddenCount == scripture._wordCount){
            Console.WriteLine("All words are hidden, restart program to test yourself again.");

        }

    


    }
}




















