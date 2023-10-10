using System;


namespace Journal_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "1. Write with random prompt \n2. Write \n3. Display \n4. Load \n5. Save \n6. Quit ";
            Journal thisJournal = new Journal(); // Initialize the Journal object

            Console.WriteLine("Welcome to the Journal Program!");

            bool continueRunning = true;
            do
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine(menu);
                Console.WriteLine("What would you like to do? "); 
                var choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Prompt newPrompt = new Prompt();
                        thisJournal.AddEntry(newPrompt.RandomPrompt());
                        break;

                    case "2":
                        Console.Write("Enter your custom prompt: "); //EXCEED REQUIREMENTS: I created a new option that lets the user create their own prompt, write about it and save it.
                        string promptText = Console.ReadLine(); // EXCEED REQUIREMENTS: I also made a loop that lets the user keep using the program without it closing after every single response.
                        thisJournal.AddEntry(promptText);
                        break;

                    case "3":
                        thisJournal.DisplayEntries();
                        break;

                    case "4":
                        Console.WriteLine("Please enter the file name to open ");
                        string fileName = Console.ReadLine();
                        thisJournal.LoadEntries(fileName);
                        break;

                    case "5":
                        Console.WriteLine("Please enter the file name to save");
                        string savefileName = Console.ReadLine(); 
                        thisJournal.SaveEntries(savefileName);
                        break;

                    case "6":
                        continueRunning = false; //set to exit the loop
                        break;

                    case "q":

                    default:    
                        Console.WriteLine("Not found, please choose something from the menu");
                        continueRunning = true; //set to continue the loop
                        break;
                }
            } while (continueRunning);
        }   
    }
}
