// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите 2 целых положительных числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int DegreeDigit(int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * DegreeDigit(num1, num2 - 1);
}

Console.WriteLine(DegreeDigit(a, b));