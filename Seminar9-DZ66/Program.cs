// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int n, m, s=0;
Console.Write("Введи значение M: ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи значение N: ");
m = Convert.ToInt16(Console.ReadLine());
void PrintNumbers(int n, int m, int s)
{
for (int i = n; i <= m; i++)
    s += i;
Console.WriteLine(s);
}
PrintNumbers(n,m,s);
