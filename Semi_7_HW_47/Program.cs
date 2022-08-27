// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5      7    -2  -0,2
//   1   -3,3     8  -9,9
//   8    7,8  -7,1     9

double[,] CreateMatrixRndInt(int rows, int cols, int min, int max)
{
    double[,] matrix = new double[rows, cols];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.Next(min, max + 1) * rnd.NextDouble(), 2, MidpointRounding.ToEven);
        }        
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            // else Console.Write($"{matrix[i, j], 4}");

            Console.Write (j < matrix.GetLength(1) - 1 ? 
            $"{matrix[i, j], 6}, " : $"{matrix[i, j], 6}");
        }
        Console.WriteLine("]");
    }
    
}


double[,] arr2d = CreateMatrixRndInt(3, 4, -99, 99);
PrintMatrix(arr2d);


