using System.Threading.Tasks.Dataflow;

public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _content = "";

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} = Prompt: {_prompt}");
        Console.WriteLine($"{_content}");
        Console.WriteLine();
    }

    public string StringForFile()
    {
        return String.Format($"{_date}|{_prompt}|{_content}");
    }
    
}