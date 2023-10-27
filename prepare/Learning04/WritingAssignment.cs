public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentname, topic)

    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = HetStudentName();
        return $"{_little} by {student}";
    }
    
    
}