// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
int daynum = Convert.ToInt32(Console.ReadLine());

if (daynum == 1) 
{
    Console.WriteLine("Понедельник");
}
else if (daynum == 2) 
{
    Console.WriteLine("Вторник");
}
else if (daynum == 3) 
{
    Console.WriteLine("Среда");
}
else if (daynum == 4) 
{
    Console.WriteLine("Четверг");
}
else if (daynum == 5) 
{
    Console.WriteLine("Пятница");
}
else if (daynum == 6) 
{
    Console.WriteLine("Суббота");
}
else if (daynum == 7) 
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}


