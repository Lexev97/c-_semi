﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решить без использования строк.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int res = (a % 100) / 10;

Console.WriteLine($"Вторая цифра этого числа: {res}");
