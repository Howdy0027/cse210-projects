// Program class
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses for the events
        Address address1 = new Address("123 Park St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Maple St", "Vancouver", "BC", "Canada");

        // Create event instances
        Event lecture = new Lecture("Tech Talk", "A talk on new technologies", "06/10/2023", "10:00 AM", address1, "John Doe", 100);
        Event reception = new Reception("Company Meetup", "Annual company meetup", "07/20/2023", "2:00 PM", address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Community Picnic", "A picnic for the community", "08/15/2023", "12:00 PM", address3, "Sunny");

        // Add events to a list
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Iterate through the list and display details for each event
        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}