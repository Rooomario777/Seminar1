﻿// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int a = 2;
while (a <= number)
{
    Console.Write(a);
    Console.Write(", ");
    a += 2;
}

