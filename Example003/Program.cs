﻿Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = (-1)*n; i <= n; i++)
    Console.Write(i + " ");
