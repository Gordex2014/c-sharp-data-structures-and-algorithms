namespace Arrays.SortingAlgorithms;

public static class InsertionSort
{
    public static void Sort<T>(T[] array) where T : IComparable
    {
        for (var i = 1; i < array.Length; i++)
        {
            var j = i;
            while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
            {
                Swap(array, j, j - 1);
                j--;
            }
        }
    }

    private static void Swap<T>(IList<T> array, int first, int second)
    {
        (array[first], array[second]) = (array[second], array[first]);
    }
}