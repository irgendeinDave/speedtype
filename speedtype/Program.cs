
public class Program
{
    private static string fileLocation = String.Empty;
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Please enter a valid Path to an input file");
            return;
        }
        fileLocation = args[0];

        string[] content = File.ReadAllLines(fileLocation);
        foreach (string word in content)
        {
            Console.WriteLine($"{word} ");
            for (int i = 0; i < word.Length; ++i)
            {
                char input = Console.ReadKey().KeyChar;
            }
            Console.Clear();
        }
        
        Console.WriteLine("Hello World");
    }
}