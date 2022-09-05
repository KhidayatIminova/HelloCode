// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = GetArray(m, n, 1, 10);

// 1. Находим сумму элементов в строках массива

int[,] arrayRowSum = GetRowSum(array);

// 2. Выводим на экран массив и суммы элементов строк

PrintArrayWithSum(array, arrayRowSum);

// 3. Находим наименьшее значение суммы элементов строк массива

GetRowMinValue(arrayRowSum);

// 4. Метод, который возвращает массив, заполненный значениями сумм элементов строк входного массива

int[,] GetRowSum(int[,] arr)
{
    int[,] arrRowSum = new int[arr.GetLength(0), 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            rowSum += arr[i, j];
            arrRowSum[i, 0] = rowSum;
        }
    }
    return arrRowSum;
}

// 5. Метод, который находит строку с наименьшим значением суммы элементов входного массива 

void GetRowMinValue(int[,] arr)
{
    int minValIndex = 0;
    int minVal = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i, 0] < minVal)
        {
            minVal = arr[i, 0];
            minValIndex = i;
        }
    }
    Console.WriteLine($"\nНаименьшая сумма элементов в {minValIndex}-й строке\n");
}

// 6. Метод, который возвращает массив, заполненный случайными числами

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

// 7. Метод вывода массива и суммы элементов строк на экран

void PrintArrayWithSum(int[,] arr, int[,] arrRowSum)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.Write($"    Сумма ({i}) = {arrRowSum[i, 0]}");
        Console.WriteLine();
    }
}




