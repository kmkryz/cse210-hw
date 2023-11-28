using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Create videos
        Video video1 = new Video("Making a classic hollandaise sauce", "karensKitchen", 300);
        video1.AddComment("Alice", "Great tutorial!");
        video1.AddComment("Bob", "I learned a lot, thanks!");
        video1.AddComment("Dave", "Wow, I am so glad I decided to watch this video!");
        video1.AddComment("Lucy", "I knew I was doing something wrong, thanks for the help.");

        Video video2 = new Video("Learning how to change our bad tendancies", "ZenMaster", 500);
        video2.AddComment("Charlie", "Very informative.");
        video2.AddComment("Hunter", "This guy is full of himself");
        video2.AddComment("David", "Could you make more videos on this?");
        video2.AddComment("Peter", "I feel so much more confident now, thank you!");

        Video video3 = new Video("Machine Learning Fundamentals", "MLGenius", 600);
        video3.AddComment("Eve", "This is so cool!");
        video3.AddComment("Frank", "I have a question about the third concept.");
        video3.AddComment("Olivia", "Two words: Mind. Blown.");



        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };



        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumComments());
            Console.WriteLine();

            Console.WriteLine("Comments:");
            foreach (var comment in video._comments)
            {
                Console.WriteLine($"{comment._commenterName}: {comment._commentText}");
            }

            Console.WriteLine(); 
            Console.WriteLine();
            Console.WriteLine();
    }
}
}