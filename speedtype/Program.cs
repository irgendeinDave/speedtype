
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
        Console.WriteLine("Hello World");
    }
}