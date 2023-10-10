/*public class PromptGenerator
{
    public string RandomPrompt()
    {
        //choose from list of random prompts and display to user
        Random randomPrompt = new Random();
        int promptNum = randomPrompt.Next(1, 5);
        int prompt = Convert. ToInt32(Console.ReadLine()); //to convert, maybe?

        if (promptNum == 1)
        {
        Console.WriteLine("Who was the most interesting person I interacted with today?");
        }

        if (promptNum == 2)
        {
            Console.WriteLine("What was the best part of my day?");
        }

        if (promptNum == 3)
        {
            Console.WriteLine("How did I see the hand of the Lord in my lelse ife today?");
        }

        if (promptNum == 4)
        {
            Console.WriteLine("What was the strongest emotion I felt today?");
        }

        if (promptNum == 5)
        {
            Console.WriteLine("if I had one thing I could do over today, what would it be?");
        }   
    }   
}*/

public class Prompt
{
    public List<string> _promptList = new List<string>() {
       "Who was the most interesting person I interacted with today?",
       "What was the best part of my day?",
       "How did I see the hand of the Lord in my life today?",
       "What was the strongest emotion I felt today?",
       "if I had one thing I could do over today, what would it be?" };

    public Prompt()
    {
    }

    public string RandomPrompt()
    {
        Random rnd = new Random();
        var index = rnd.Next(_promptList.Count);
        //Console.WriteLine(_promptList[index]);
        return _promptList[index];
    }
}