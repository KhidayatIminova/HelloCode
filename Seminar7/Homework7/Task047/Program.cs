// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

double[,] array = GetArray(m, n, 1, 10);
PrintArray(array);

// 1. Метод, возвращающий двумерный массив M x N, заполненный вещественными числами

double[,] GetArray(int row, int col, int minValue, int maxValue)
{
    double[,] arr = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        Random a;
        for (int j = 0; j < col; j++)
        {
            a = new Random();
            arr[i, j] = Math.Round(a.Next(minValue, maxValue) + a.NextDouble(), 1); // случайное вещественное число с 1-м знаком после запятой
        }
    }
    return arr;
}

// 2. Метод вывод массива на экран

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{(arr[i, j]):f1} | ");
        }
        Console.WriteLine();
    }
}

