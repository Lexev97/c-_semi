// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int ConvertToBin(int num)
{
    int result = 0;
    int mult = 1;
    
    while (num > 0)
    {
        result += num % 2 * mult;
        num = num / 2;
        mult *= 10;
    }

    return result;
}

Console.Write($"Двоичный формат числа: {ConvertToBin(a)}");

// С помощью рекурсии:

void DecToBin(int num)
{
    if(num == 0) return;
    DecToBin(num / 2);
    Console.Write(num % 2);
}

Console.WriteLine();
DecToBin(a);