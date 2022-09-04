// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите 2 целых положительных числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());


int SumDigits(int num1, int num2)
{
    int sum = num1;
    if (num1 == num2) return num1;
    return sum += SumDigits(num1 + 1, num2);
}

Console.WriteLine(a > b ? SumDigits(b, a) : SumDigits(a, b));
