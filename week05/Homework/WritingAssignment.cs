public class WritingAssignment:Assignment
{
    // private string _studentName;
    // private string _topic;
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        // _studentName = studentName;
        // _topic = topic;
        _title = title;
    }
    // public string GetSummary()
    // {
    //     return $"{_studentName} - {_topic}";
    // }

    public string GetWritingInformatio()
    {
        return $"{_title} by {GetStudentName()}";
    }
}