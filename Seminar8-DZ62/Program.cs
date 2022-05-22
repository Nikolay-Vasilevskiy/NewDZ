//Задача 62: Заполните спирально массив 4 на 4.
int N = 4;
            int val = 1;
            int x = -1;
            int y = 0;
            int [,] mass = new int[N,N];
            for (int i = 1; i < 2*N; i++)
            {
                for (int j = 0; j < N-i/2; j++)
                {
                    mass[y += (i%4 - 1)%2, x -= (i%4 - 2)%2] = val++;
                }
            }
 
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i,j]+" ");
                }
                Console.WriteLine();
            }

           