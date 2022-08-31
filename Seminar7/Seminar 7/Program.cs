// Console.Clear();

// // Задайте двумерный массив, заполненный случайными целыми числами

// Console.Write("Введите количество строк массива: ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int N = int.Parse(Console.ReadLine());

// int [,] array = GetArray(M, N, 1, 10);
// PrintArray(array);

// // 1. Создание двумерного массива M x N

// int [,] GetArray(int m, int n, int minValue, int maxValue) // входные параметры: число строк, число столбцов, минимальное и максимальное значения
// {
//     int [,] array = new int[m,n];
//     for (int i = 0; i < m;i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue);
//         }
//     }

//     return array;
// }

// // 2. Печать двумерного массива

// void PrintArray(int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0);i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"[{arr[i,j]}]");
//         }
//         Console.WriteLine();
//     }


// }


// // Задача 48. Задайте двумерный массив, размера m x n, каждый элемент в массиве находится по формуле Amn = m + n

// Console.Write("Введите количество строк массива: ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int N = int.Parse(Console.ReadLine());

// int [,] array = GetArray(M, N);
// PrintArray(array);

// // 1. Создание двумерного массива M x N

// int [,] GetArray(int m, int n) // входные параметры: число строк, число столбцов, минимальное и максимальное значения
// {
//     int [,] array = new int[m,n];
//     for (int i = 0; i < m;i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i,j] = i + j;
//         }
//     }

//     return array;
// }

// // 2. Печать двумерного массива

// void PrintArray(int [,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0);i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"[{arr[i,j]}]");
//         }
//         Console.WriteLine();
//     }


// }

// Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты

Console.Write("Введите m ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n ");
int n = int.Parse(Console.ReadLine());

int [,] array = GetArray(m, n, 1, 10);
PrintArray(array);
MakeArray(array);
PrintArray(array);
//GetSum(array);
Console.WriteLine(GetSum(array));


int [,] GetArray(int row, int col, int minValue, int maxValue)
{
    int [,] arr = new int[m,n];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(minValue,maxValue);
        }
    }
    return arr;
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

// 3. Возведение в квадрат элементов с четными индексами i и j
void MakeArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr[i, j] *= arr[i, j];
            }
        }
        Console.WriteLine();
    }
}

// 4. Суммирование элементов главной диагонали (11, 22, 33 и т.д.)
//void GetSum(int [,] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += arr[i, j];
//             }
//         }
//     }
//     Console.WriteLine(sum);
// }

int GetSum(int [,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += arr[i, j];
            }
        }
    }
    return sum;
}


// Задача 51. Задайте двумерyый массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты 