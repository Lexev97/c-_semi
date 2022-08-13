// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

// 2 | 1
// __|__
// 3 | 4


Console.WriteLine("Введите номер четверти:");
int num = Convert.ToInt32(Console.ReadLine());

string GetQuarter (int area)
{
    if(area == 1) return "х и у больше нуля";
    else if(area == 2) return "х меньше нуля и у больше нуля";
    else if(area == 3) return "х и у меньше нуля";
    else if(area == 4) return "х больше нуля и у меньше нуля";
    else return "Введены не корректные координаты";
}

string result = GetQuarter (num);
Console.WriteLine(result);
