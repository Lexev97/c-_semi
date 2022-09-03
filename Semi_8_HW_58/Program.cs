// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multipliedMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < multipliedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multipliedMatrix.GetLength(1); j++)
        {
            int tempVal = 0;
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                tempVal += matrix1[i, k] * matrix2[k, j];
            }

            multipliedMatrix[i, j] = tempVal;
        }
    }
    return multipliedMatrix;

}

int[,] arr2dA = CreateMatrixRndInt(2, 2, 1, 9);
int[,] arr2dB = CreateMatrixRndInt(2, 2, 1, 9);

Console.WriteLine("Матрица А:");   
PrintMatrix(arr2dA);

Console.WriteLine("Матрица B:");  
PrintMatrix(arr2dB);
if (arr2dA.GetLength(1) != arr2dA.GetLength(0)) Console.WriteLine("Матрицы несовместимы. Число столбцов матрицы А должно быть равно числу строк матрицы В");
else 
{
    int[,] multArr2d = MultiplyMatrix(arr2dA, arr2dB);
    Console.WriteLine("Результирующая матрица будет:");    
    PrintMatrix(multArr2d);
}




