public class LoadorSave
{
    public string _writing = "";
    public void Load()
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            _writing = _writing + line + $"\n";
        }
        _writing = lines[0];
    }

    public void Save()
    {
        Console.WriteLine(" ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.Write(_writing);
        }
    }
}