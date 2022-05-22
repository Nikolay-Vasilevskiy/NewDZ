//Задача 58: Задайте две матрицы. Напишите программу, которая будет
//находить произведение двух матриц.
int[,] mass1 = new int[2, 2];
int[,] mass2 = new int[2, 2];
int[,] m = mult(mass1, mass2);
int[,] mult(int[,] mass1, int[,] mass2)
{

for (int i = 0; i < mass1.GetLength(0); i++)
{
    for (int j = 0; j < mass1.GetLength(1); j++)
    {

        mass1[i, j] = new Random().Next(1, 10);
        Console.Write(mass1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < mass2.GetLength(0); i++)
{
    for (int j = 0; j < mass2.GetLength(1); j++)
    {

        mass2[i, j] = new Random().Next(1, 10);
        Console.Write(mass2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int[,] m = new int[mass1.GetLength(0), mass2.GetLength(1)];
    for (int i = 0; i < mass1.GetLength(0); ++i)
        for (int j = 0; j < mass2.GetLength(0); ++j)
            for (int k = 0; k < mass2.GetLength(1); ++k)
                m[i, k] += mass1[i, j] * mass2[j, k];
    return m;
}


for (int i = 0; i < mass1.GetLength(0); ++i)
{
    for (int j = 0; j < mass2.GetLength(1); ++j)
    {
        Console.Write(m[i, j] + " ");
    }
    Console.WriteLine();
}
