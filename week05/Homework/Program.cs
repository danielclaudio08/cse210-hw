using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Daniel Claudio", "Math in the Real World");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Daniel Claudio", "Geometry", "Section 9.0", "Problems 18-27");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment  = new WritingAssignment("Daniel Claudio", "Literature", "Romeo and Juliet");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}