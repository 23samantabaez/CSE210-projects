
class Scripture
{

    private Reference reference;

    private List<Word> words = new List<Word>();


    public Scripture(string referenceText, string scriptureText)
    {
        reference = new Reference (referenceText);
        words.AddRange(scriptureText.Split(' ').Select(word => new Word(word)));
    }

    //Hide random word in scripture

    public void HideRandomWord()
    {
        List<Word> unhiddenWords = words.Where(word => !word.Hidden).ToList();

        if (unhiddenWords.Count > 0)
        {
            Word wordToHide = unhiddenWords[new Random().Next(unhiddenWords.Count)];
            wordToHide.Hide();
        }
    }

    //Check if all words in scripture are hidden
    public bool AllWordsHidden()
    {
        return words.All(word => word.Hidden);
    }

    public override string ToString()
    {
        return $"{reference}\n{string.Join(" ", words)}";
    }
}