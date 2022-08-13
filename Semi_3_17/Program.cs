// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

// 2 | 1
// __|__
// 3 | 4

// тийминг: 29:12

Console.WriteLine("Введите координаты точки:");
Console.Write("Х:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int y = Convert.ToInt32(Console.ReadLine());

// if(x > 0 && y > 0) Console.WriteLine("Первая чатверть");
// else if(x < 0 && y > 0) Console.WriteLine("Вторая чатверть");
// else if(x < 0 && y < 0) Console.WriteLine("Третья чатверть");
// else if(x > 0 && y < 0) Console.WriteLine("Четвертая чатверть");
// else Console.WriteLine("Введены не корректные координаты");

string GetQuarter (int xc, int yc)
{
    if(xc > 0 && yc > 0) return "Первая чатверть";
    else if(xc < 0 && yc > 0) return "Вторая чатверть";
    else if(xc < 0 && yc < 0) return "Третья чатверть";
    else if(xc > 0 && yc < 0) return "Четвертая чатверть";
    else return "Введены не корректные координаты";

}

string result = GetQuarter (x, y);
Console.WriteLine(result);
