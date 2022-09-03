// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int[,] DeleteRowAndColOfMinValue(int[,] matrix)
{
    int row = default;
    int col = default;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j]) min = matrix[i, j]; 
        }
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int j = default;
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            if (min == matrix[i, j])
            {
                row = i;
                col = j;
                break;
            }
        }
        if (min == matrix[i, j]) break; 
    }

    int[,] matrix2 = new int [matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (i < row && j < col) matrix2[i, j] = matrix[i, j];
            else if (i >= row && j >= col) matrix2[i, j] = matrix[i + 1, j + 1];
            else if (i < row && j >= col) matrix2[i, j] = matrix[i, j + 1];
            else if (i >= row && j < col) matrix2[i, j] = matrix[i + 1, j];
        }
    }

    return matrix2;
}

int[,] arr2d = CreateMatrixRndInt(8, 6, 1, 9);
PrintMatrix(arr2d);
int[,] secArr2d = DeleteRowAndColOfMinValue(arr2d);
PrintMatrix(secArr2d);