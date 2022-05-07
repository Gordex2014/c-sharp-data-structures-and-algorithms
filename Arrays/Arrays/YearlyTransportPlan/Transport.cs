using System.Globalization;

namespace Arrays.YearlyTransportPlan;

public class Transport
{
    private readonly Random _random = new Random();
    private readonly int _transportTypesCount = Enum.GetNames(typeof(TransportEnum)).Length;
    private readonly TransportEnum[][] _transport = new TransportEnum[12][];

    public void GenerateTransportData()
    {
        for (var month = 1; month <= 12; month++)
        {
            var daysCount = DateTime.DaysInMonth(DateTime.Now.Year, month);
            _transport[month - 1] = new TransportEnum[daysCount];
            for (var day = 1; day <= daysCount; day++)
            {
                var randomTransportType = _random.Next(_transportTypesCount);
                _transport[month - 1][day - 1] = (TransportEnum)randomTransportType;
            }
        }
    }

    public void PrintTransportPlan()
    {
        var monthNames = GetMonthNames();
        // Calculating the necessary width for the month names
        var monthNamesWidth = monthNames.Max(x => x.Length + 2);
        for (var month = 1; month <= _transport.Length; month++)
        {
            Console.Write($"{monthNames[month - 1]}:".PadRight(monthNamesWidth));
            for (var day = 1; day <= _transport[month - 1].Length; day++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = _transport[month - 1][day - 1].GetColor();
                Console.Write(_transport[month - 1][day - 1].GetChar());
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }

    private static string[] GetMonthNames()
    {
        var monthNames = new string[12];
        for (var month = 1; month <= 12; month++)
        {
            var firstDay = new DateTime(DateTime.Now.Year, month, 1);
            var monthName = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
            monthNames[month - 1] = monthName;
        }

        return monthNames;
    }
}