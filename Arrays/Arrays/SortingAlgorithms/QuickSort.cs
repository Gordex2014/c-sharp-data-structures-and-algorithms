namespace Arrays.SortingAlgorithms;

public static class QuickSort
{
    public static void Sort<T>(T[] array) where T : IComparable
    {
        Sort(array, 0, array.Length - 1);
    }

    private static T[] Sort<T>(T[] array, int lower, int upper)
        where T : IComparable
    {
        if (lower >= upper) return array;
        var p = Partition(array, lower, upper);
        Sort(array, lower, p);
        Sort(array, p + 1, upper);

        return array;
    }

    private static int Partition<T>(IList<T> array, int lower, int upper)
        where T : IComparable
    {
        var i = lower;
        var j = upper;
        var pivot = array[lower];
        // or: T pivot = array[(lower + upper) / 2];
        do
        {
            while (array[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (array[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i >= j)
            {
                break;
            }

            Swap(array, i, j);
        } while (i <= j);

        return j;
    }

    private static void Swap<T>(IList<T> array, int first, int second)
    {
        (array[first], array[second]) = (array[second], array[first]);
    }
}