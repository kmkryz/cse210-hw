using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Create videos
        Video video1 = new Video("Introduction to C#", "CSharpLover123", 300);
        video1.AddComment("Alice", "Great tutorial!");
        video1.AddComment("Bob", "I learned a lot, thanks!");

        Video video2 = new Video("Web Development Basics", "WebDevMaster", 500);
        video2.AddComment("Charlie", "Very informative.");
        video2.AddComment("David", "Could you make more videos on CSS?");

        Video video3 = new Video("Machine Learning Fundamentals", "MLGenius", 600);
        video3.AddComment("Eve", "This is mind-blowing!");
        video3.AddComment("Frank", "I have a question about the third concept.");

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumComments());

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(); // Add a newline for better readability
    }
}
}