using System;

Console.Write("Введите двоичное число");
string binary = Console.ReadLine();
Console.WriteLine($"Результат: {Convert.ToInt32(binary, 2)}");


Console.Write("Введиет десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Двоичное: {Convert.ToString(number, 2)}");

Console.WriteLine("Введите Часы:");
string hours = Console.ReadLine();
Console.WriteLine("Введите Минуты: ");
string minutes = Console.ReadLine();
int hourZ = Convert.ToInt32(hours, 10);
int minuteZ = Convert.ToInt32(minutes, 10);
int resThree = hourZ * 60 + minuteZ;
Console.WriteLine("Всего мунут: " + resThree);
