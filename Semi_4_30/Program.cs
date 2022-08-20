// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] FillArray()
{
    int[] array = new int[8];

    Random rnd = Random();

    for (int i = 0; i <= 7; i++)
    {
        array[i] = new rnd.Next(0, 2);
    }

    return array;
}

int[] res = FillArray();

void PrintArray()
{
    Console.Write("[");
    for (int i = 0; i <= 7; i++)
    {
        Console.Write($"{res[i]},");
    }
    Console.Write("]");
}

PrintArray();
