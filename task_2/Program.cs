﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Enter 3 numbers: ");
int a = Convert.ToInt32(System.Console.ReadLine());
int b = Convert.ToInt32(System.Console.ReadLine());
int c = Convert.ToInt32(System.Console.ReadLine());
int max = a;
if (b>max)
{
    max=b;
}
if (c>max)
{
    max=c;
}
System.Console.WriteLine($"Максимальное число {max}");