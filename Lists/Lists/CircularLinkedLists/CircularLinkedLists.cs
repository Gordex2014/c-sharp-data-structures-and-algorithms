namespace Lists.CircularLinkedLists;

public class CircularLinkedLists
{
    public void SpinTheWheel()
    {
        var categories = new CircularLinkedList<string>();
        categories.AddLast("Sport");
        categories.AddLast("Culture");
        categories.AddLast("History");
        categories.AddLast("Geography");
        categories.AddLast("People");
        categories.AddLast("Technology");
        categories.AddLast("Nature");
        categories.AddLast("Science");

        var random = new Random();
        var totalTime = 0;
        var remainingTime = 0;
        foreach (string category in categories)
        {
            if (remainingTime <= 0)
            {
                Console.WriteLine("Press [Enter] to star or [X] to exit.");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        totalTime = random.Next(1000, 5000);
                        remainingTime = totalTime;
                        break;
                    case ConsoleKey.X:
                        return;
                    default:
                        return;
                }
            }

            var categoryTime = (-450 * remainingTime) / (totalTime - 50) + 500 + (22500 / (totalTime - 50));
            remainingTime -= categoryTime;
            Thread.Sleep(categoryTime);
            Console.ForegroundColor = remainingTime <= 0
                ? ConsoleColor.Red
                : ConsoleColor.Gray;
            Console.WriteLine(category);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}