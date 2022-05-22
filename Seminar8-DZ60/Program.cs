//Задача 60: Сформируйте трёхмерный массив из неповторяющихся
//двузначных чисел. Напишите программу, которая будет построчно выводить
//массив, добавляя индексы каждого элемента.
int[,,] mass = new int[2, 2, 2];
int[] arr = new int[mass.Length];
int count = 0;
bool current = false;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int k = 0; k < mass.GetLength(2); k++)

        {
            mass[i, j, k] = new Random().Next(10, 99);
            current = false;
            for (int c = 0; c < count; c++)
            {
                if (mass[i, j, k] == arr[c])
                {
                    current = true;
                    k--;
                    break;
                }
            }
            if (current == false)
            {
                Console.WriteLine($"Число {mass[i, j, k]} - индекс:({i},{j},{k}).");
                arr[count] = mass[i, j, k];
                count++;
            }
        }
    }
    Console.WriteLine();
}