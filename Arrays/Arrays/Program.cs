// See https://aka.ms/new-console-template for more information

using Arrays;
using Arrays.SortingAlgorithms;
using Arrays.TerrainGame;
using Arrays.Utils;
using Arrays.YearlyTransportPlan;

// Single dimensional array example
Printer.PrintTitle("Single dimensional array example");
var months = new Months();
months.PrintMonths();

// Multi dimensional array example
Printer.PrintTitle("Multi dimensional array examples");
var multiplicationArray = new MultiplicationTable();
multiplicationArray.FillTable();
multiplicationArray.PrintTable();

Printer.PrintLine();
var terrainMap = new TerrainGame();
terrainMap.PrintMap();

// Jagged array example
Printer.PrintTitle("Jagged array example");
var transport = new Transport();
transport.GenerateTransportData();
transport.PrintTransportPlan();

// Sorting examples
Printer.PrintTitle("Sorting examples");
var integerValues = new int[] { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
string[] stringValues =
{
    "Mary", "Marcin", "Ann", "James",
    "George", "Nicole"
};

// Selection sort
var integerValuesSelectionSortCopy = integerValues.Clone() as int[];
var stringValuesSelectionSortCopy = stringValues.Clone() as string[];
Printer.PrintSubtitle("Selection sort");
if (integerValuesSelectionSortCopy != null)
{
    SelectionSort.Sort(integerValuesSelectionSortCopy);
    Console.WriteLine(string.Join(" | ", integerValuesSelectionSortCopy));
}

if (stringValuesSelectionSortCopy != null)
{
    SelectionSort.Sort(stringValuesSelectionSortCopy);
    Console.WriteLine(string.Join(" | ", stringValuesSelectionSortCopy));
}

// Insertion sort
var integerValuesInsertionSortCopy = integerValues.Clone() as int[];
var stringValuesInsertionSortCopy = stringValues.Clone() as string[];
Printer.PrintSubtitle("Insertion sort");
if (integerValuesInsertionSortCopy != null)
{
    InsertionSort.Sort(integerValuesInsertionSortCopy);
    Console.WriteLine(string.Join(" | ", integerValuesInsertionSortCopy));
}

if (stringValuesInsertionSortCopy != null)
{
    InsertionSort.Sort(stringValuesInsertionSortCopy);
    Console.WriteLine(string.Join(" | ", stringValuesInsertionSortCopy));
}

// Bubble sort
var integerValuesBubbleSortCopy = integerValues.Clone() as int[];
var stringValuesBubbleSortCopy = stringValues.Clone() as string[];
Printer.PrintSubtitle("Bubble sort");
if (integerValuesBubbleSortCopy != null)
{
    BubbleSort.Sort(integerValuesBubbleSortCopy);
    Console.WriteLine(string.Join(" | ", integerValuesBubbleSortCopy));
}

if (stringValuesBubbleSortCopy != null)
{
    BubbleSort.Sort(stringValuesBubbleSortCopy);
    Console.WriteLine(string.Join(" | ", stringValuesBubbleSortCopy));
}

// Bubble sort optimized
var integerValuesBubbleSortOptimizedCopy = integerValues.Clone() as int[];
var stringValuesBubbleSortOptimizedCopy = stringValues.Clone() as string[];
Printer.PrintSubtitle("Bubble sort optimized");
if (integerValuesBubbleSortOptimizedCopy != null)
{
    BubbleSortOptimized.Sort(integerValuesBubbleSortOptimizedCopy);
    Console.WriteLine(string.Join(" | ", integerValuesBubbleSortOptimizedCopy));
}

if (stringValuesBubbleSortOptimizedCopy != null)
{
    BubbleSortOptimized.Sort(stringValuesBubbleSortOptimizedCopy);
    Console.WriteLine(string.Join(" | ", stringValuesBubbleSortOptimizedCopy));
}

// Quick sort
var integerValuesQuickSortCopy = integerValues.Clone() as int[];
var stringValuesQuickSortCopy = stringValues.Clone() as string[];
Printer.PrintSubtitle("Quick sort");
if (integerValuesQuickSortCopy != null)
{
    QuickSort.Sort(integerValuesQuickSortCopy);
    Console.WriteLine(string.Join(" | ", integerValuesQuickSortCopy));
}

if (stringValuesQuickSortCopy != null)
{
    QuickSort.Sort(stringValuesQuickSortCopy);
    Console.WriteLine(string.Join(" | ", stringValuesQuickSortCopy));
}