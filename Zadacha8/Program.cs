﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int counter = 2;
while(counter <= N)
{
    Console.Write(counter + " ");
    counter = counter + 2;
}