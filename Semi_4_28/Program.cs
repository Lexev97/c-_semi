// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите произвольное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int MeltiplyDigits(int num)
{
    int res = 1;

    if (num > 0) 
    {
        for (int i = 1; i <= num; i++)
        {
            res = res * i;
        }

        return res;
    } 

    return 0;
    
}

Console.Write($"{a} -> {MeltiplyDigits(a)}");
