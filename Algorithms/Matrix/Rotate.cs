namespace Algorithms.Matrix;

public class Rotate
{
    // Time Complexity — O(n × m)
    public static byte[,] Rotate90Clockwise(byte[,] input)
    {
        int height = input.GetLength(0);
        int width = input.GetLength(1);

        byte[,] rotated = new byte[width, height];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                rotated[j, height - 1 - i] = input[i, j];
            }
        }

        return rotated;
    }
}
