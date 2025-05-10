namespace Algorithms.Matrix;

public class ResizeImage
{
    /// <summary>
    /// Resizes a grayscale image using nearest-neighbor interpolation.
    /// Time Complexity: O(newHeight × newWidth)
    /// Space Complexity: O(newHeight × newWidth)
    /// </summary>
    public static byte[,] ResizeNearestNeighbor(byte[,] input, int newHeight, int newWidth)
    {
        int originalHeight = input.GetLength(0);
        int originalWidth = input.GetLength(1);

        byte[,] resized = new byte[newHeight, newWidth];

        for (int i = 0; i < newHeight; i++)
        {
            for (int j = 0; j < newWidth; j++)
            {
                int origI = (int)((i / (double)newHeight) * originalHeight);
                int origJ = (int)((j / (double)newWidth) * originalWidth);
                
                origI = Math.Min(origI, originalHeight - 1);
                origJ = Math.Min(origJ, originalWidth - 1);

                resized[i, j] = input[origI, origJ];
            }
        }

        return resized;
    }
}
