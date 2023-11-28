using System;

class Program
{
    static void Main(string[] args)
    {
        

        Address address1 = new Address("123 Main St", "Cityville", "CA", "12345");
        Lecture lectureEvent = new Lecture("Tech Talk", "Exciting tech discussion", "2023-01-15", "15:00", address1, "John Doe", 50);

        Address address2 = new Address("456 Park Ave", "Townsville", "NY", "67890");
        Reception receptionEvent = new Reception("Networking Mixer", "Casual networking event", "2023-02-20", "18:30", address2, "rsvp@example.com");

        Address address3 = new Address("789 Outdoor Rd", "Villagetown", "TX", "13579");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Community Picnic", "Family-friendly picnic", "2023-03-25", "12:00", address3, "Sunny with a high of 75°F");

        Event[] events = { lectureEvent, receptionEvent, outdoorEvent };

        foreach (var e in events)
        {
            Console.WriteLine("\n--- Standard Details ---");
            Console.WriteLine(e.StandardDetails());

            Console.WriteLine("\n--- Full Details ---");
            Console.WriteLine(e.FullDetails());

            Console.WriteLine("\n--- Short Description ---");
            Console.WriteLine(e.ShortDescription());
    }
}
}