using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int _totalPoints = 0;
        List <Goal> goals = new List<Goal>();

        string DisplayMenu()
        {
            //string choice = "";
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Points: {_totalPoints} "); //Displays number of points that the user currently has
            Console.WriteLine();
            Console.WriteLine("\nMenu Options: \n1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            return choice;
        }

        string selectedItem = DisplayMenu();

        /*string Reading() //saving
        {
            string filename = "myFile.txt"; //Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                string firstName = parts[0];
                string lastName = parts[1];
            }
        }*/

        /*ListGoals()
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine($"{_totalPoints}, {goals.Count}"); //exceeding

                foreach (var goal in goals)
                {
                    outputFile.WriteLine(goal.Serialize());
                }
            }
        }*/

        while (selectedItem != "6")
        {

            if (selectedItem == "1")
            {
                Console.WriteLine("The Types of goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal ");
                Console.WriteLine("Which type of goal would you like to create? ");
                string goalChoice = Console.ReadLine();
                string goalType = goalChoice;

                if (goalType == "1")
                {
                    Console.WriteLine("You chose a simple goal");
                    new SimpleGoal();
                    Console.ReadLine();
                }
                else if (goalType == "2")
                {
                    Console.WriteLine("You chose an eternal goal");
                    new EternalGoal();
                    Console.ReadLine();
                }
                else if (goalType == "3")
                {
                    Console.WriteLine("You chose a checklist goal");
                    new ChecklistGoal();
                    Console.ReadLine();
                }
            }

            if (selectedItem == "2") //Listing goals
            {
                Console.WriteLine("You chose to list the goals");
                //Reading();
                //filename = "myFile.txt";
                //serializedGoal();

                /*using (StreamWriter outputFile = new StreamWriter())
                {
                    outputFile.WriteLine($"{_totalPoints}, {goals.Count}"); //exceeding

                    foreach (var goal in goals)
                    {
                        outputFile.WriteLine(goal.Serialize());
                    }
                }*/

                /*
                foreach (var goal in goals)
                {
                    Console.WriteLine(goal.PrintGoal());
                }
                Console.ReadLine(); */
            }

            if (selectedItem == "3") //saving Goals
            {
                Console.WriteLine("option three");
                Console.WriteLine("Enter the filename for saving the goals: ");
                string filename = Console.ReadLine();

                var lines = new List<string>();
                lines.Add($"{_totalPoints}, {goals.Count()}");

                foreach (var i in goals)
                {
                    lines.Add(i.Serialize());
                }
                File.WriteAllLines(filename, lines);
            }
            
            if (selectedItem == "4") //Loading Goals
            {
                Console.WriteLine("You chose option four");
                Console.WriteLine("Enter the filename for saving the goals: ");
                string filename = Console.ReadLine();

                var lines = File.ReadAllLines(filename);
                goals.Clear();
                 /*
                var header = lines[0].Split(",");//**
                _totalPoints = int.Parse(header[0]);
                var totalGoals = int.Parse(header[1]);*/

                /*for (var i = 0; i < totalGoals; i++)
                {
                    Goal().Deserialize(serializedGoal);
                    //goals.Add(goal);
                }*/

            }

            if (selectedItem == "5") //Recording Goals
            {
                Console.WriteLine("option five");
                Console.WriteLine("What goal do you want to complete? ");
                int selectedIndex = int.Parse(Console.ReadLine());
                var goal = goals[selectedIndex - 1];
                //_totalPoints += goal.RecordEvent();
                Console.ReadLine();
            }

            selectedItem = DisplayMenu(); // get user input agin inside loop to update selectedItem, to break loop
        }

        /*else
        {
            Console.WriteLine("Please select an option from the menu");
            Console.ReadLine();
        }*/
        
    }
}