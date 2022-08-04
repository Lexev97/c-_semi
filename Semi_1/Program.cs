// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49


Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); // int - значения от - 2 147 483 648 до 2 147 483 647
int square = number * number;
Console.WriteLine("Квадрат введенного числа: " + square);
// или
Console.WriteLine($"Квадрат введенного числа: {number} = {square}");

if (number == 5 && number ==7)
{

}
else if (number == 6 || number != 3) 
{

}
else
{

}