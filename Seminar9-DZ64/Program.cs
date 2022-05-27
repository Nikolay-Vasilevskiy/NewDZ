//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа в промежутке от M до N.
//M = 6; N = 2. -> "6, 5, 4, 3, 2"
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
void PrintNumbers(int n, int m)
{
    if (m > n)

        for (int i = n; i <= m; i++)
            Console.Write($" {i}");
    else
        for (int i = m; i <= n; i++)
            Console.Write($" {i}");

}
PrintNumbers(n, m);
