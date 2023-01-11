using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnum = randomGenerator.Next(1, 100);

        bool go = true;
        while (go)
        {
            Console.Write("What is your Guess? ");
            string input = Console.ReadLine();
            int guess = int.Parse(input);
            if (guess > magicnum)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicnum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                go = false;
            }
        }
    }
}