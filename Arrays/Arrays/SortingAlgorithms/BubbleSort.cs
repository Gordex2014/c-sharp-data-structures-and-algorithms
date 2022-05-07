namespace Arrays.SortingAlgorithms;

public static class BubbleSort
{
    public static void Sort<T>(T[] array) where T : IComparable
    {
        foreach (var t in array)
        {
            for (var j = 0; j < array.Length - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    Swap(array, j, j + 1);
                }
            }
        }
    }

    private static void Swap<T>(IList<T> array, int first, int second)
    {
        (array[first], array[second]) = (array[second], array[first]);
    }
}