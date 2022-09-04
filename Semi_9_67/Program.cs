// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());


int SumDigit(int num)
{
    int sum = num % 10;
    if (num == 0) return sum;
    
    return sum += SumDigit(num / 10);
}

int res = SumDigit(a);
Console.WriteLine($"{a} -> {res}");

