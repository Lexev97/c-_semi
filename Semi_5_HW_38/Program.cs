// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.Next(min, max + 1) * rnd.NextDouble(), 1, MidpointRounding.ToEven);
    }

    return array;
}

double MinMaxDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max) max = array[i];
        else if (array[i] <= min) min = array[i];
    }

    
    return max - min;

}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

double[] arr = CreateArrayRndInt(5, 1, 100);
MinMaxDifference(arr);


PrintArray(arr);
Console.WriteLine($" -> {MinMaxDifference(arr)}");

