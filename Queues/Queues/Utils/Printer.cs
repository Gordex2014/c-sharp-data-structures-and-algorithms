namespace Queues.Utils;

public static class Printer
{
    public static void PrintTittle(string title)
    {
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"{title}".PadLeft(12));
        Console.WriteLine("-------------------------------------------------------------");
    }
    
    public static void Log(string text)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}]{text}");
    }
}