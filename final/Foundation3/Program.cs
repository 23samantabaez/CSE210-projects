using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Event objects

        Event lectureEvent = new Lecture("Lecture event Title", "Lecture event description", "December 8, 2023", "10:00 AM", "700 Boul Lamontagne, Sainte Marie Qc", "Larry Joe", "100 people" );
        Event receptionEvent = new Reception("Reception Title", "Reception Description", "December 8, 2023", "7:00 PM", "278 West, Centerville", "rsvp@example.com");
        Event outdoorEvent = new OutdoorGathering("Outdoor Event Title", "Outdoor Event Description","March 27, 2024","3:00 PM", "address3", "Sunny");


        Console.WriteLine("EVENT TRACKER");
        Console.WriteLine("These are the scheduled events");
        Console.WriteLine();

        //display messages
        //Lecture
        Console.WriteLine("EVENT #1");
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();
        
        Console.WriteLine("Full Details: ");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description: ");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("____________________________________");
        Console.WriteLine();


        //Reception
        Console.WriteLine("EVENT #2");
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details: ");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description: ");
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("____________________________________");
        Console.WriteLine();


        //Outdoor Gathering
        Console.WriteLine("EVENT #3");
        Console.WriteLine();
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details: ");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description: ");
        Console.WriteLine(outdoorEvent.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("____________________________________");
        Console.WriteLine();
    }
}