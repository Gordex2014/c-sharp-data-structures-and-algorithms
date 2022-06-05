namespace Lists.Utils;

public static class Printer
{
    public static void PrintSection(string sectionTitle)
    {
        Console.WriteLine("----------------------------------------------------------------------------------");
        Console.WriteLine($"{sectionTitle}");
        Console.WriteLine("----------------------------------------------------------------------------------");
    }

    public static void PrintSeparation()
    {
        Console.WriteLine("----------------------------------------------------------------------------------");
    }

    public static void PrintNote(string note)
    {
        Console.WriteLine("----------------------------------------------------------------------------------");
        Console.WriteLine($"* Note: {note}");
    }

    public static void PrintBulletPoint(string text)
    {
        Console.WriteLine($" *: {text}");
    }
}