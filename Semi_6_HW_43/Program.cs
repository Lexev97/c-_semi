// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты двух прямых");
Console.Write("A1: ");
double a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("A2: ");
double a2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double[] GetCrossPoint(double b1, double k1, double b2, double k2)
{  

    // y = k1 * x + b1;
    // y = k2 * x + b2;

    // y - y = k1 * x + b1 - (k2 * x + b2);
    // y = k2 * x + b2;

    // 0 = (k1-k2) * x + (b1 - b2);
    // y = k2 * x + b2;

    // - (b1 - b2) = (k1-k2) * x;
    // y = k2 * x + b2;

    // -(b1 - b2) / (k1 - k2) = x;
    // y = k2 * x + b2;

    // x = -(b1 - b2) / (k1 - k2);
    // y = k2 * ((- b1 - b2) / (k1 + k2)) + b2;

    
    double x = -(b1 - b2) / (k1 - k2);
    double y = k2 * (-(b1 - b2) / (k1 - k2)) + b2;

    double[] crossPoint = {x, y};
    return crossPoint;
}

void PrintArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write(array[i]);
    }
    Console.Write(")");
}

double[] crossPointArr = GetCrossPoint(a1, b1, a2, b2);

Console.Write("Точка пересечения 2-х прямых имеет следующие координаты: ");
PrintArray(crossPointArr);