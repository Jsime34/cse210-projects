using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Oak Ave", "Othertown", "NY", "67890");
        Address address3 = new Address("789 Pine Rd", "Anycity", "TX", "11223");

        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest in tech", "2024-08-15", "10:00 AM", address1, "Jane Doe", 100);
        Reception reception = new Reception("Networking Event", "An event to network with professionals", "2024-08-20", "12:00 PM", address2, "rsvp@example.com");
        Outdoor outdoorGathering = new Outdoor("Summer Festival", "A fun outdoor festival", "2024-08-21", "4:00 PM", address3, "Sunny with a chance of clouds");

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };
        foreach (var e in events)
        {
            Console.WriteLine("Standard Details:\n" + e.GetStandardDetails());
            Console.WriteLine("Full Details:\n" + e.GetFullDetails());
            Console.WriteLine("Short Description:\n" + e.GetShortDescription());
            Console.WriteLine();
        }
    }
}