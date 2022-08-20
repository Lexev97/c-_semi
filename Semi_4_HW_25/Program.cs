// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



Console.WriteLine("Введите произвольное число: ");
Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());

int ExpAB(int num1, int num2)
{
    int res = num1;

    for (int i = 1; i < num2; i++)
    {
        res = res * num1;
    }

    return res;
}

Console.WriteLine($"{a}, {b} -> {ExpAB(a, b)}");