public class Write
{
    string[] prompts = {"What was the best part of your day?", "What do you plan on doing tommorow?", "What was the best thing you ate today?", "How could today have been better?", "How did you help someone today?", "What are you gratefull for today?"};

    public string WritePrompt()
    {
        Random rnd = new Random();
        int prompt = rnd.Next(prompts.Length);
        string usedPrompt = prompts[prompt];
        Console.WriteLine(usedPrompt);
        Console.Write("> ");
        string input = Console.ReadLine();
        DateTime today = DateTime.Today;
        string todaystr = today.ToString("d");
        string product = $"Date: {todaystr} - Prompt: {usedPrompt}\n{input}";
        return product;
    }
}