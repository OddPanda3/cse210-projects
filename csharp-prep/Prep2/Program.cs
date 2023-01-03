using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.Write("What was your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got an {letter} in this class.");

        if (percent >= 70)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("Unfortunatly, you did not pass, better luck next time.");
        }


    }
}