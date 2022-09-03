// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int FindRowWithMinValSum(int[,] matrix)
{
    int[] rowsSums = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {  
            rowsSums[i] += matrix[i, j];
        }        
    }

    int minRowSumIndex = 0;
        
    for (int i = 1; i < rowsSums.Length; i++)
    {
        if (rowsSums[i] < rowsSums[minRowSumIndex]) minRowSumIndex = i;
    }

    return minRowSumIndex + 1;
}

int[,] arr2d = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(arr2d);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindRowWithMinValSum(arr2d)} строка");
