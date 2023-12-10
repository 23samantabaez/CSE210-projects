using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>(); //activity list
        
        //activity objects, //2 running, 2 bikes, 1 swimming
        Activity runningActivity = new Running(new DateTime(2023, 11, 3), 30, 3.5);
        Activity runningActivity1 = new Running(new DateTime(2023, 11, 3), 10, 1.0);
        Activity cyclingActivity = new Cycling(new DateTime(2023, 11, 3), 12, 8.0);
        Activity cyclingActivity1 = new Cycling(new DateTime(2023, 11, 3), 15, 6.0);
        Activity swimmingActivity = new Swimming(new DateTime(2023, 11, 3), 20, 10);

        activities.Add(runningActivity);
        activities.Add(runningActivity1);
        activities.Add(cyclingActivity);
        activities.Add(cyclingActivity1);
        activities.Add(swimmingActivity);

        Console.Clear();
        Console.WriteLine("________________________________________________________________________");
        Console.WriteLine();
        Console.WriteLine("EXCERCISE TRACKING APP");
        Console.WriteLine("________________________________________________________________________");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Activities: ");
        Console.WriteLine();

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }

        Console.WriteLine("________________________________________________________________________");
        Console.WriteLine();
        Console.WriteLine();

    }
}