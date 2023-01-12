using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        

        bool go = true;
        while (go)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int num = int.Parse(input);
            if (num != 0)
            {
                numbers.Add(num);
            }
            else
            {
                go = false;
            }
        }
        int sum = numbers.Sum();
        int average = sum / numbers.Count;
        int max = numbers.Max();
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
    }
}