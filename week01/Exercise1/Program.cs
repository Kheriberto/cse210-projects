using System;

class Program
{
    static void Main(string[] args)
    {
        string fnme = "";
        string lnme = "";
        
        Console.Write("What is your first name? ");
        fnme = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        lnme = Console.ReadLine();
        
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lnme}, {fnme} {lnme}");
    }
} 