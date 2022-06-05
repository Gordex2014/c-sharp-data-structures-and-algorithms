using Lists.Models;

namespace Lists.LinkedLists;

public class LinkedLists
{
    public void BookReader()
    {
        // Individual pages
        var pageFirst = new Page() { Content = "Nowadays (...)" };
        var pageSecond = new Page() { Content = "Application (...)" };
        var pageThird = new Page() { Content = "A lot of (...)" };
        var pageFourth = new Page() { Content = "Do you know (...)" };
        var pageFifth = new Page() { Content = "While (...)" };
        var pageSixth = new Page() { Content = "Could you (...)" };

        // Using linked lists to concatenate the pages
        var pages = new LinkedList<Page>();
        pages.AddLast(pageSecond);
        var nodePageFourth = pages.AddLast(pageFourth);
        pages.AddLast(pageSixth);
        pages.AddFirst(pageFirst);
        pages.AddBefore(nodePageFourth, pageThird);
        pages.AddAfter(nodePageFourth, pageFifth);

        // Printing the book
        PrintBook(pages);
    }

    private static void PrintBook(LinkedList<Page> pages)
    {
        LinkedListNode<Page>? current = pages.First;
        var number = 1;
        var appRunning = true;
        while (current != null && appRunning)
        {
            Console.Clear();
            var numberString = $"- {number} -";
            var leadingSpaces = (90 - numberString.Length) / 2;
            Console.WriteLine(numberString.PadLeft(leadingSpaces + numberString.Length));
            Console.WriteLine();
            var content = current.Value.Content;
            for (var i = 0; i < content.Length; i += 90)
            {
                var line = content.Substring(i);
                line = line.Length > 90 ? line[..90] : line;
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine(
                $"Quote from 'Windows Application Development Cookbook' by Marcin Jamro,{Environment.NewLine}published by Packt Publishing in 2016.");
            Console.WriteLine();
            Console.Write(current.Previous != null ? "< PREVIOUS [P]" : GetSpaces(14));
            Console.Write(current.Next != null ? "[N] NEXT >".PadLeft(76) : string.Empty);
            Console.WriteLine($"\n{GetSpaces(30)}[X] EXIT >");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.N:
                    if (current.Next != null)
                    {
                        current = current.Next;
                        number++;
                    }

                    break;
                case ConsoleKey.P:
                    if (current.Previous != null)
                    {
                        current = current.Previous;
                        number--;
                    }

                    break;

                case ConsoleKey.X:
                    appRunning = false;
                    break;

                default:
                    return;
            }
        }
    }

    private static string GetSpaces(int number)
    {
        var result = string.Empty;
        for (var i = 0; i < number; i++)
        {
            result += " ";
        }

        return result;
    }
}