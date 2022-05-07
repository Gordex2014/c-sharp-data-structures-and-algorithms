namespace Arrays.Utils;

public static class Printer
{
    public static void PrintTitle(string title)
    {
        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine(title);
        Console.WriteLine("-----------------------------------------------------");
    }
    
    public static void PrintSubtitle(string subtitle)
    {
        Console.WriteLine($"{subtitle}:");
    }

    public static void PrintLine()
    {
        Console.WriteLine("-----------------------------------------------------");
    }
}