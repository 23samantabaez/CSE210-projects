using System;

class Program
{
    static void Main(string[] args)
    {
        //predefined scripture
        string referenceText = "John 3:16";
        string scriptureText = "Insert scripture here";

        //create scripture object w/ predefined reference and text
        Scripture scripture = new Scripture(referenceText, scriptureText);

        //main loop: allow the user to hide words in scripture
        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.Write("Press Enter to hide a word, or type 'quit' to exit: ");
            string userInput = GetUserInput() ?? ""; //asign empty string if GetUserInput() returns null

            if(userInput.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
        }

        //Display final scripture with hidden words
        Console.Clear();
        Console.WriteLine(scripture);

        Console.ReadLine();
    }

    static string? GetUserInput()
    {
        return Console.ReadLine();
    }

    


}