using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);

        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"{letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congradulations, You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the class");
        }
    }
}