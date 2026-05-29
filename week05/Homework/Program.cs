using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("George Bush", "Why dinos die.");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Conner", "Math", "4.5", "7-9");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Conner Monson", "Writing", "The end of the world");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}