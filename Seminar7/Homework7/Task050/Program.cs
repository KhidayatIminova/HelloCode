// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = GetArray(m, n, 1, 10);

PrintArray(array);
Console.WriteLine();

Console.Write("Введите номер строки: ");
int i = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int j = int.Parse(Console.ReadLine());

Console.WriteLine($"\n{FindElement(i, j, array)}");

// 1. Метод, возвращающий двумерный массив M x N, заполненный целыми числами

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arr;
}

// 2. Метод вывод массива на экран

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

// 3. Метод, возвращающий строковое значение элемента массива по заданным индексам строки и столбца элемента, либо сообщение, что такого элемента нет

string FindElement(int rowIndex, int columnIndex, int[,] arr)
{
    string sNum = string.Empty;

    if (rowIndex < arr.GetLength(0) && columnIndex < arr.GetLength(1))
    {
        int num = 0;
        num = arr[i, j];
        sNum = $"Элемент с позицией [{rowIndex}, {columnIndex}] равен " + num.ToString() + " \n";

    }
    else
    {

        sNum = $"Элемента с позицией [{rowIndex}, {columnIndex}] в массиве не существует\n";

    }
    return sNum;
}
