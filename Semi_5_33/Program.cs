// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
}

void FindDigit(int[] array, int digit)
{
    int fDigit = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == digit) fDigit = i;
    }   

    if (fDigit < 0) Console.WriteLine("Данная цифра отсутствует в массиве");
    else Console.WriteLine("Данная цифра присутствует в массиве");
    
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] arr = CreateArrayRndInt(8, -10, 10);
PrintArray(arr);

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
FindDigit(arr, a);