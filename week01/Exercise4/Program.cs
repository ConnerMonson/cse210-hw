using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime;

class Program
{
    static void Main(string[] args)
    {

        List<int>numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int userNumber;

        do
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber!= 0);

        int sum = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        int count = numbers.Count;
        int average = sum / count;





        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}