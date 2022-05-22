// Задача 54: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] mass = new int[1, 4];
            
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                
                    mass[i, j] = new Random().Next(10, 99);
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
 
            var arr = mass.Cast<int>().OrderByDescending(a => a).ToArray();
 
            int c = 0;
            for (int j = 0; j < mass.GetLength(0); j++)
            {
                for (int k = 0; k < mass.GetLength(1); k++)
                {
                    mass[j, k] = arr[c];
                    Console.Write(mass[j, k] + " ");
                    c++;
                }
                Console.WriteLine();
            }