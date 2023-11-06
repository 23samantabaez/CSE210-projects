using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
    

    bool run = true;
      while(run)
      {
        Console.WriteLine("\n --- Welcome to the Mindfulness Program ---");
        Console.WriteLine("\nMenu Options:\n1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Positive affirmations Activity\n5. Exit");
        Console.WriteLine();
        Console.WriteLine("Select an option from the menu: ");
        string option = Console.ReadLine();
        switch(option)
        
       {
        case "1":
           
            Activity act = new Activity();
            Console.Clear();
            act.SetActName("Breathing");
            act.SetActAbout("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine(act.GetWelcome());
            act.MethodSpin();
            act.SetSecondes(act.MethodTimer());

            Breathing brea = new Breathing();
            brea.BreathInOut(act.GetSecondes());
           
            Console.WriteLine(act.MethodBye());
            
            break;

        case "2":
            
            Activity act2 = new Activity();
            Console.Clear();
            act2.SetActName("Reflecting");
            act2.SetActAbout("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine(act2.GetWelcome());
            act2.MethodSpin();
            act2.SetSecondes(act2.MethodTimer());

            Reflecting reflec = new Reflecting();
            reflec.Reflectioning(act2.GetSecondes());
            
            Console.WriteLine(act2.MethodBye());
            
            break;

        case "3":
           
            Activity act3 = new Activity();
            Console.Clear();
            act3.SetActName("Listing");
            act3.SetActAbout("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
            Console.WriteLine(act3.GetWelcome());
            act3.MethodSpin();
            Listing listing = new Listing();
            act3.SetSecondes(act3.MethodTimer());
            listing.ListCore(act3.GetSecondes());
            Console.WriteLine(act3.MethodBye());
            
            break;

        case "4":
            
            Activity act4 = new Activity();
            Console.Clear();
            act4.SetActName("Positive Affirmations");
            act4.SetActAbout("This activity will help you to increase your confidence. The things you say to yourself play a big role in your attitude and in your daily positivity.");
            Console.WriteLine(act4.GetWelcome());
            act4.MethodSpin();
            Positive positive = new Positive(); //EXCEEDING REQUIREMENTS: created a new menu option/activity
            act4.SetSecondes(act4.MethodTimer());
            positive.Confidence(act4.GetSecondes());
            Console.WriteLine(act4.MethodBye());
           
            break;

        case "5":

            Console.WriteLine("Until next time, goodbye!");
            run=false;

            break;
        
        default:
            Console.WriteLine("Invalid option, please try again.");
            continue;
        } 
      }
    }
}









/*using System;

class Program
{
    static void Main(string[] args)
    {
        static string SelectMenuItem()
        {
            string _userChoice = "";
            List<string> options = new List<string>{"1", "2", "3", "4"};

            while (!options.Contains(_userChoice, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Mindfulnes Space");
                Console.WriteLine();
                string menu = "1. Start breathing activity \n2. Start reflecting activity \n3. Start listing activity \n4. Quit"; //can I call it directly or from outside? 
                Console.WriteLine(menu);
                Console.WriteLine();
                Console.WriteLine("Please select one activity from the menu: "); //user input, create a variable, convert to string
                _userChoice = Console.ReadLine();
                Console.WriteLine();
            }
            return _userChoice;
        }

        string _selectedItem = "";
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        while(_selectedItem != "4")
        {
            _selectedItem = SelectMenuItem();

            if (_selectedItem == "1")
            {
                breathingActivity.RunActivity();
            }

            else if (_selectedItem == "2")
            {
                reflectingActivity.RunActivity();
            }

            else if (_selectedItem == "3")
            {
                listingActivity.RunActivity();
            }
        }

        Console.WriteLine("\nWell done! \n");
    }
}



/*class Activity
{
    private string _name;
    {
        _activityName = name;
    }

    private string _description;
    {
        _activityDescription = _description;
    }

    private int _duration;
    {
        _activityDuration = _duration;
    }

}*/