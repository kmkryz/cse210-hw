using System;

class Program
{
    static void Main(string[] args)
    {
        

        Address address1 = new Address("1768 Main St", "Fairhaven", "CA", "12345");
        Lecture lectureEvent = new Lecture("Tech Talk", "Exciting tech discussion featuring the\nnewest updates for TBoT Max!", "01-15-2023", "3:00 PM", address1, "Thomas Rankin", 50);

        Address address2 = new Address("456 Park Ave", "Cocoaville", "FL", "67890");
        Reception receptionEvent = new Reception("Networking Mixer", "Casual networking event for\nnewest employees with Obexum", "02-23-2023", "5:30 PM", address2, "rsvp@example.com");

        Address address3 = new Address("729 Outkin Rd", "Carpe Village", "TX", "13579");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Community 4th of July Picnic", "Family-friendly picnic,\nfireworks, BBQ, and fun!", "07-02-2023", "12:00 PM", address3, "Sunny with a high of 75°F");

        Event[] events = { lectureEvent, receptionEvent, outdoorEvent };

        foreach (var e in events)
        {
            Console.WriteLine("\n--- Standard Details ---");
            Console.WriteLine(e.StandardDetails());

            Console.WriteLine("\n--- Full Details ---");
            Console.WriteLine(e.FullDetails());

            Console.WriteLine("\n--- Short Description ---");
            Console.WriteLine(e.ShortDescription());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
    }
}
}