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