// Задача 41: Пользователь вводит с клавиатуры M чисел.
 // Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Write("Пользователь вводит числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//int [] arr = new int [10];
//for ( int i = 0; i < arr.Length; i++)
//{
//arr[i] = new Random().Next(-10,10);
//Console.Write(arr[i] + " ");
//}
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");
