namespace Arrays.TerrainGame;

public static class TerrainEnumExtension
{
    public static ConsoleColor GetColor(this TerrainEnum terrain)
    {
        return terrain switch
        {
            TerrainEnum.Grass => ConsoleColor.Green,
            TerrainEnum.Sand => ConsoleColor.Yellow,
            TerrainEnum.Water => ConsoleColor.Blue,
            _ => ConsoleColor.DarkGray
        };
    }

    public static char GetChar(this TerrainEnum terrain)
    {
        return terrain switch
        {
            TerrainEnum.Grass => '\u201c',
            TerrainEnum.Sand => '\u25cb',
            TerrainEnum.Water => '\u2248',
            _ => '\u25cf'
        };
    }
}