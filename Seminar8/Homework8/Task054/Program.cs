// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = GetArray(m, n, 1, 10);

Console.WriteLine();
PrintArray(array);
Console.WriteLine();

// 1. Вызываем метод сортировки элементов строк массива

SortArray(array);
PrintArray(array);

// 2. Метод сортировки элементов каждой строки по убыванию

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] > arr[i, k])
                {
                    int n = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = n;
                }
            }
        }
    }
}

// 3. Метод, который возвращает массив, заполненный случайными числами

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arr;
}

// 4. Метод вывода масcива на экран

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

