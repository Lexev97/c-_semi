// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int a = new Random().Next(10, 100); 
Console.WriteLine($"Cлучайное число из отрезка [10, 99] - {a}");

// int firstDigit = a / 10;
// int secDigit = a % 10;

// Обычный способ:
// if (firstDigit == secDigit) Console.WriteLine("Цифры равны");
// else if (firstDigit > secDigit)  Console.WriteLine($"Наибольшая цифра числа {a} => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {a} => {secDigit}");

// Вариант решения с помощью тернарного оператор:
// string result = firstDigit == secDigit ? "Цифры равны" : firstDigit > secDigit ? firstDigit.ToString() : secDigit.ToString(); 
// Console.WriteLine($"Наибольшая цифра числа {a} => {result}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secDigit = num % 10;
    if (firstDigit == secDigit) return 0;
    return firstDigit > secDigit ? firstDigit : secDigit;
}

int result = MaxDigit(a);
string res = result == 0 ? "Цифры равны" : result.ToString();
Console.WriteLine($"Наибольшая цифра числа {a} => {res}");

