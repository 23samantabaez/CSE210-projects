//reference class represents scripture reference

class Reference
{

    public string ReferenceText { get; }

    public Reference(string referenceText)
    {
        ReferenceText = referenceText;
    }

    public override string ToString()
    {
        return ReferenceText;
    }
}