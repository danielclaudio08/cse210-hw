public class WritingAssignment : Assignment
{
  private string _title;

  public WritingAssignment(string studentName, string topic, string title)
  : base(studentName, topic)
  {
    _title = title;
  }

  public string GetWritingInformation()
  {
    return $"\n{_studentName} - {_topic} \n{_title} by {_studentName}";
  }

}