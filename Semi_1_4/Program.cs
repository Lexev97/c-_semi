﻿// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"


Console.Write("Напишите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Вывод чисел в промежутке от -N до N: ");
for (int i = -a; i <= a; i++)
{
    Console.Write(i + " ");
}
