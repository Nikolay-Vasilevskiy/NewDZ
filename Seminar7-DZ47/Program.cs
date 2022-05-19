﻿// Задача 47: Задайте двумерный массив размером m×n,заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
var m = 3;
var n = 4;
double[,] mass = new double[m, n];

Random random = new Random();
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j <mass.GetLength(1); j++)
    {
        mass[i, j] = random.Next(-10, 10) + random.Next(0,5)/10.0;// даёт случайные вещественные отрицательные
        // и положительные число в диапазоне от -10 до 10, "/10.0"-десятые доли после запятой

        //mass[i, j] = random.NextDouble()*10; // дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,8:F2}",mass[i, j]);// "{0,8:F2}" сокращает цифры после запятой
    }
    Console.WriteLine();
}
