// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

int[] ConvertArrToInt(string[] array)
{
    int[] intArr = new int[array.Length];

    for (int i = 0; i < intArr.Length; i++)
    {
        intArr[i] = Convert.ToInt32(array[i]);
    }

    return intArr;
}

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

int FindNumInMatrix(int[,] matrix, int[] searchRequest)
{
    int res = -1;
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    if (rows <= searchRequest[0] && cols <= searchRequest[1]) return res;
    else res = matrix[searchRequest[0]-1, searchRequest[1]-1];

    return res;
}

int[,] arr2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(arr2d);

Console.WriteLine("Введите номер столбца и номер строки через запятую:");
string[] input = Console.ReadLine().Split(", ");
int[] checkMatrixArr = ConvertArrToInt(input);

Console.WriteLine(FindNumInMatrix(arr2d, checkMatrixArr) > 0 ? $" -> {FindNumInMatrix(arr2d, checkMatrixArr)}" : " -> такого элемента в массиве нет");