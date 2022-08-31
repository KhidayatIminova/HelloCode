// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];  

FillArray(array, 1, 10);           

PrintArray(array);               

GetColumnSum(array);             

GetColumnAverage(array);         
Console.WriteLine();

// 1. Метод заполнения массива случайными целыми числами

void FillArray(int[,] arr, int minValue, int maxValue)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);

        }
    }
}

// 2. Метод вывода массива на экран

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"  {arr[i, j]} | ");
        }
        Console.WriteLine();
    }
}

// 3. Метод расчета и вывода на экран среднего арифметического элементов каждого столбца

void GetColumnAverage(int[,] arr)
{
    Console.WriteLine($"\nСреднее арифметическое чисел столбцов массива:\n");

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double ColumnSum = 0;
        double ColumnAverage = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            ColumnSum += arr[i, j];
            ColumnAverage = ColumnSum / arr.GetLength(0);
        }

        Console.Write($"{(ColumnAverage):f2}  ");

    }
    Console.WriteLine();
}

// 4. Метод расчета и вывода на экран суммы элементов каждого столбца (для визуализации)

void GetColumnSum(int[,] arr)
{
    Console.WriteLine($"\nСумма чисел столбцов массива:\n");

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double ColumnSum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            ColumnSum += arr[i, j];

        }

        Console.Write($" {ColumnSum}   ");

    }
    Console.WriteLine();
}
