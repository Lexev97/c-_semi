// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

// int res = 0;

// for (int i = 1; i <= n; i++)
// {
//     res = res +i;
// }

// Console.WriteLine($"{n} -> {res}");

int SumNumbers (int num)
{
    int res = 0;

    for (int i = 1; i <= n; i++)
    {
        res += i;
    }

    return res;
}

int result = SumNumbers (n);
Console.WriteLine($"{n} -> {result}");