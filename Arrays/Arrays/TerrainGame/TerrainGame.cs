using System.Text;

namespace Arrays.TerrainGame;

public class TerrainGame
{
    private readonly TerrainEnum[,] _map =
    {
        {
            TerrainEnum.Sand, TerrainEnum.Sand, TerrainEnum.Sand,
            TerrainEnum.Sand, TerrainEnum.Grass, TerrainEnum.Grass,
            TerrainEnum.Grass, TerrainEnum.Grass, TerrainEnum.Grass,
            TerrainEnum.Grass
        },
        {
            TerrainEnum.Water, TerrainEnum.Water, TerrainEnum.Water,
            TerrainEnum.Water, TerrainEnum.Water, TerrainEnum.Water,
            TerrainEnum.Water, TerrainEnum.Wall, TerrainEnum.Water,
            TerrainEnum.Water
        }
    };

    public void PrintMap()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (var row = 0; row < _map.GetLength(0); row++)
        {
            for (var column = 0; column < _map.GetLength(1); column++)
            {
                // Setting the color of the character
                Console.ForegroundColor = _map[row, column].GetColor();
                // Printing the character
                Console.Write(_map[row, column].GetChar() + " ");
            }

            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.Gray;
    }
}