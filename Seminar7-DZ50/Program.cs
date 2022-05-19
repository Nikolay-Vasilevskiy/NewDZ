// Задача 50: Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание,что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
int m = 3;
int n = 4;
System.Console.WriteLine("Введите число find: ");
int find = int.Parse(Console.ReadLine());
bool f = false;
int[,] mass = new int[m, n];// Случайнный Массив 3 на 4
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);

        if (find == mass[i, j]) { m = i; n = j; f = true;};
        Console.Write("{0}\t", mass[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
if (f)
    Console.WriteLine($"Число: найдено. Строка {m + 1} Столбец {n + 1}");
else
    Console.WriteLine("Число: не найдено");