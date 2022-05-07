namespace Arrays.YearlyTransportPlan;

public static class TransportEnumExtensions
{
    public static char GetChar(this TransportEnum transport)
    {
        return transport switch
        {
            TransportEnum.Bike => 'B',
            TransportEnum.Bus => 'U',
            TransportEnum.Car => 'C',
            TransportEnum.Subway => 'S',
            TransportEnum.Walk => 'W',
            _ => throw new Exception("Unknown transport")
        };
    }

    public static ConsoleColor GetColor(
        this TransportEnum transport)
    {
        return transport switch
        {
            TransportEnum.Bike => ConsoleColor.Blue,
            TransportEnum.Bus => ConsoleColor.DarkGreen,
            TransportEnum.Car => ConsoleColor.Red,
            TransportEnum.Subway => ConsoleColor.DarkMagenta,
            TransportEnum.Walk => ConsoleColor.DarkYellow,
            _ => throw new Exception("Unknown transport")
        };
    }
}