// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int arrayLength = 8;

int[] FillArray(int lng)
{
    int[] array = new int[lng];

    for (int i = 0; i < lng; i++)
    {
        array[i] = new Random().Next(0, 100);
    }

    return array;
}

int[] res = FillArray(arrayLength);

void PrintArray(int lng)
{
    for (int i = 0; i < lng; i++)
    {
        if (i == lng - 1) Console.Write($"{res[i]}");
        else Console.Write($"{res[i]}, ");
    }
    Console.Write("  -> [");
    for (int i = 0; i < lng; i++)
    {
        if (i == lng - 1) Console.Write($"{res[i]}");
        else Console.Write($"{res[i]}, ");
    }
    Console.Write("]");
}

PrintArray(arrayLength);
