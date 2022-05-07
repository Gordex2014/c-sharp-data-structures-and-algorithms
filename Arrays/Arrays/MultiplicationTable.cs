namespace Arrays;

public class MultiplicationTable
{
    private readonly int[,] _results = new int [10, 10];

    public void FillTable()
    {
        for (var i = 0; i < _results.GetLength(0); i++)
        {
            for (var j = 0; j < _results.GetLength(1); j++)
            {
                _results[i, j] = (i + 1) * (j + 1);
            }
        }
    }

    public void PrintTable()
    {
        for (var i = 0; i < _results.GetLength(0); i++)
        {
            for (var j = 0; j < _results.GetLength(1); j++)
            {
                Console.Write("{0,4}", _results[i, j]);
            }

            Console.WriteLine();
        }
    }
}