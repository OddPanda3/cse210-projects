using System;

class Program
{
    static void Main(string[] args)
    {
        Write write = new Write();
        bool go = true;
        LoadorSave loadorsave = new LoadorSave();
        while (go)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                loadorsave._writing = loadorsave._writing + write.WritePrompt() + $"\n";
            }
            else if (input == "2")
            {
                Console.WriteLine(loadorsave._writing);
            }
            else if (input == "3")
            {
                loadorsave.Load();
            }
            else if (input == "4")
            {
                loadorsave.Save();
            }
            else
            {
                go = false;
            }
        }
    }
}