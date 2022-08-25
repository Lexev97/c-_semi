// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите лубое количество чисел через пробел:");
string[] input = Console.ReadLine().Split();

int[] ConvertArrToInt(string[] array)
{
    int[] intArr = new int[array.Length];

    for (int i = 0; i < intArr.Length; i++)
    {
        intArr[i] = Convert.ToInt32(array[i]);
    }

    return intArr;
}

void HowManyPosDigits(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }

    Console.Write($"{count} из введенных чисел > 0");
}

int[] intInput = ConvertArrToInt(input);
HowManyPosDigits(intInput);

