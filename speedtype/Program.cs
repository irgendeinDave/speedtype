
public class Program
{
    private static string fileLocation = String.Empty;
    private static ConsoleColor standardForegroundColor = Console.ForegroundColor;
    private static string[] content;
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Please enter a valid Path to an input file");
            return;
        }
        fileLocation = args[0];

        content = File.ReadAllLines(fileLocation);
        while (true)
        {
            string word = getNextWord();
            Console.Write($" {word} ");
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
                Console.ForegroundColor = standardForegroundColor;
            }
            Console.Clear();
        }
    }

    private static int currentListIndex = -1;
    private static string getNextWord()
    {
        Random rand = new();
        currentListIndex = (currentListIndex + rand.Next(1, content.Length)) % content.Length;
        return content[currentListIndex];
    }
}