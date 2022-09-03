// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

void rplaceMatrixRowsByCols(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1)) 
    {
        Console.WriteLine("Строки на столбцы заменить не возможно");
        return;
    }

    int tempValue = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1 + i; j < matrix.GetLength(0); j++)
        {
            tempValue = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = tempValue;
        }        
    }
}

int[,] arr2d = CreateMatrixRndInt(3, 4, 1, 9);

PrintMatrix(arr2d);
Console.WriteLine();

rplaceMatrixRowsByCols(arr2d);
PrintMatrix(arr2d);
