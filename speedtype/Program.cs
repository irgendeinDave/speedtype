
public class Program
{
    private static string fileLocation = String.Empty;
    private static ConsoleColor standardForegroundColor = Console.ForegroundColor;
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
            string typedWord = String.Empty;
            for (int i = 0; i < word.Length; ++i)
            {
                char input = Console.ReadKey(true).KeyChar;
                typedWord += input;
                Console.ForegroundColor = standardForegroundColor;
                if (word[i] == input)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(input);

            }
            Console.Clear();
        }
    }
}