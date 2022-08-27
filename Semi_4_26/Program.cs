// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int HowManyDigits(int num)
{
    if (num < 0) num = num * -1;
    
    int count = 1;

   while (num >= 10)
   {
    num /= 10;
    count++;
   }

    return count;
}

Console.WriteLine($"В введенном числе {HowManyDigits (n)} цифр(ы,а).");