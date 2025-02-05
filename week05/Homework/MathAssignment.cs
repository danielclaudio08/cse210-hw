public class MathAssignment : Assignment
{
  private string _textbookSection;
  private string _problems;

  public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    : base(studentName, topic)
  {
    _textbookSection = textbookSection;
    _problems = problems;
  }
  public string GetHomeworkList()
  {
    return $"\n{_studentName} - {_topic}\n{_textbookSection} {_problems}";
  }
}