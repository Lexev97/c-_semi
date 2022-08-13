// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите 2-х точек:");
Console.Write("х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double HipDim (int a1, int a2, int b1, int b2)
{
    return Math.Sqrt( (a1 - b1) * (a1 - b1) + (a2 - b2) * (a2 - b2) );
}

double result = HipDim (x1, y1, x2, y2);
Console.WriteLine("Расстояние между точками составляет: {0: #.##}", result);