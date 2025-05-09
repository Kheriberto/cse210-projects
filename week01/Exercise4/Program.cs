using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        int newNumber;
        List<int> numbers = new List<int>();
        List<int> positiveNumbers = new List<int>();

        Console.WriteLine("\nEnter a series of numbers, type 0 when finished\n");

        do
        {
            Console.Write("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());
            numbers.Add(newNumber);

            if (newNumber > 0)
            {
                positiveNumbers.Add(newNumber);
            }

        } while (newNumber != 0);
        
        numbers.Remove(0);
        numbers.Sort();
        positiveNumbers.Sort();
        int totalSum = numbers.Sum();
        double avgNumbers = numbers.Average();
        int maxNumber = numbers.Max();
        int minPosNumber = positiveNumbers.Min();

        Console.WriteLine($"\nThe sum is: {totalSum}\nThe average is: {avgNumbers}\nThe largest number is: {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {minPosNumber}\n");
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}