// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
        
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            // else Console.Write($"{matrix[i, j], 4}");

            Console.Write (j < matrix.GetLength(1) - 1 ? 
            $"{matrix[i, j], 4}, " : $"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
    
}

void EvenIndexNumsToSqr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
        
    }
}

int[,] arr2d = CreateMatrixRndInt(3, 4, 1, 99);
PrintMatrix(arr2d);
Console.WriteLine();
EvenIndexNumsToSqr(arr2d);
PrintMatrix(arr2d);

