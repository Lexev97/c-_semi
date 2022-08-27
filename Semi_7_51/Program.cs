// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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

void MatrixDiaNumsSum(int[,] matrix)
{
    int res = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) res += matrix[i, j];
        }
        
    }

    Console.WriteLine($"Сумма элементов главной диагонали: {res}");
}

int[,] arr2d = CreateMatrixRndInt(3, 4, 1, 99);
PrintMatrix(arr2d);
Console.WriteLine();
MatrixDiaNumsSum(arr2d);
