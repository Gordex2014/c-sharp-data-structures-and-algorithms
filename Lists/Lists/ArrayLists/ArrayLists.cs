using System.Collections;

namespace Lists.ArrayLists;

public class ArrayLists
{
    private readonly ArrayList _arrayList = new ArrayList();

    public void FillList()
    {
        _arrayList.Add(5);
        _arrayList.AddRange(new int[] { 6, -7, -8 });
        _arrayList.AddRange(new object[] { "Marcin", "Mary" });
        _arrayList.Insert(6, 7.8);
    }

    public void PrintList()
    {
        foreach (var element in _arrayList)
        {
            Console.WriteLine(element);
        }
    }

    public void ArrayListOperations()
    {
        Console.WriteLine("Count: _arrayList.Count");
        Console.WriteLine(_arrayList.Count);
        Console.WriteLine("Capacity: _arrayList.Capacity");
        Console.WriteLine(_arrayList.Capacity);
        Console.WriteLine("Contains: _arrayList.Contains(-7)");
        Console.WriteLine(_arrayList.Contains(-7));
        Console.WriteLine("IndexOf: _arrayList.IndexOf(7.8)");
        Console.WriteLine(_arrayList.IndexOf(7.8));
        
    }
}