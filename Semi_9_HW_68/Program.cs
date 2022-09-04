// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите два неотрицательных целых числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int AkFunction(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if ((num1 != 0) && (num2 == 0)) return AkFunction(num1 - 1, 1);
    else return AkFunction(num1 - 1, AkFunction(num1, num2 - 1));
}

Console.WriteLine(AkFunction(a, b));
