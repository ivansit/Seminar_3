﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число А: ");
int num = Convert.ToInt32(Console.ReadLine());
int countdigit(int num)
{
int count = 0;
while (num > 0)
    {
    num /= 10;
    count++;
    }
    return count;
}
Console.WriteLine($"Количество цифр в числе = {countdigit(num)}");