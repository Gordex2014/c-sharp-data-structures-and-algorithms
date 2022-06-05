namespace Stacks.Utils
{
    public static class Printer
    {
        public static void PrintTitle(string title)
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"{title}");
            Console.WriteLine("-------------------------------------------------------------------");
        }

        public static void PrintNote(string note)
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($" * Note: {note}");
        }

        public static void PrintBulletPoint(string text)
        {
            Console.WriteLine($"  *: {text}");
        }
    }
}

