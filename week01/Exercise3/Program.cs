using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int guess;
        int attempts = 0;
        string outcome;
        string response = "yes";
        bool compare;
        List<int> usedNumbers = new List<int>();

        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1,100);
        
        do
        {   
            Console.Write("Guess the magic number: ");
            guess = int.Parse(Console.ReadLine());

            compare = guess == magicNumber;

            if (!compare)
                {
                    if (guess > magicNumber)
                        {
                            outcome = "Lower";
                        }
                    else
                        {
                            outcome = "Higher";
                        }
                    
                    if (!usedNumbers.Contains(guess))
                        {
                            usedNumbers.Add(guess);
                        }
                    else
                        {
                            Console.WriteLine($"You have tried {guess} before.");
                        }
                    attempts += 1;
                    Console.WriteLine($"{outcome}");
                }
            else
                {
                    attempts += 1;
                    Console.WriteLine();
                    Console.WriteLine($"You've guessed it! The magic number is {guess}!");
                    if (attempts == 1)
                        {
                            Console.WriteLine($"It took you {attempts} attempt");
                        }
                    else
                        {
                            Console.WriteLine($"It took you {attempts} attempts");
                        }
                    magicNumber = randomGenerator.Next(1,100);
                    Console.Write("\nDo you want to play again? ");
                    response = Console.ReadLine();
                    Console.WriteLine();
                    usedNumbers.Clear();
                    attempts = 0;
                }
        } while (response == "yes");
        Console.Write("Thank you for playing this game!\n");
    }
}