// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int DigitsSum(int num)
{
    if (num < 0) num *= -1;
    
    int sum = 0;

    while (num >= 1)
    {
        sum = sum + (num % 10);
        num /= 10;
    }

    return sum;
}

Console.WriteLine($"{a} -> {DigitsSum(a)}");