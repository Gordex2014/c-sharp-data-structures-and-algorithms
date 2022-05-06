using System.Globalization;

namespace Arrays;

public class Months
{
    private readonly string[] _months = new string[12];

    private void PopulateMonths()
    {
        for (var month = 1; month <= 12; month++)
        {
            var firstDay = new DateTime(DateTime.Now.Year, month, 1);
            var monthName = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("en"));
            _months[month - 1] = monthName;
        }
    }

    public void PrintMonths()
    {
        PopulateMonths();
        foreach (var month in _months)
        {
            Console.WriteLine(month);
        }
    }
}