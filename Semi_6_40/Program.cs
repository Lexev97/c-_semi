// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

Console.WriteLine("Введите 3 числа");
Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("C: ");
int c = Convert.ToInt32(Console.ReadLine());

void TriangleIsPossible(int num1, int num2, int num3)
{
    if (a > b + c || b > a + c || c > b + a) Console.WriteLine("Треугольника с такими сторонами не может быть");
    else Console.WriteLine("Треугольник с такими сторонами может быть");
}

TriangleIsPossible(a, b, c);