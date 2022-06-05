using System;
namespace Stacks.ReversingWords
{
    public static class ReversingWords
    {
        public static void ReverseWord(string word)
        {
            Console.WriteLine("");
            Console.WriteLine("Reversing words example, reverting {0}", word);

            var chars = new Stack<char>();

            foreach (char character in word)
            {
                chars.Push(character);
            }

            while (chars.Count > 0)
            {
                Console.Write(chars.Pop());
            }

            Console.WriteLine();
        }
    }
}

