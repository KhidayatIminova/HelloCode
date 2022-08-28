// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int m = 3;
int n = 4;

int [,] array = new int [3, 4];

int a = 1;
int b = 10;

FillArray(array, a, b);
PrintArray(array);
Console.WriteLine();
GetSumTable(array);
Console.WriteLine();
GetAverageTable(array);


void FillArray(int [,] arr, int minValue, int maxValue)
{
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
            
        }
    }
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"  {arr[i,j]} | ");
        }
        Console.WriteLine();
    }
}

void GetAverageTable (int [,] arr)
{
    Console.WriteLine ($"\nСреднее арифметическое чисел столбцов массива:");
    Console.WriteLine();

    for (int j = 0; j < arr.GetLength(1); j++)
        {
            double SumTable = 0;
            double AverageTable = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                SumTable += arr[i,j];
                AverageTable = SumTable/3;
            }
           
            Console.Write ($"{(AverageTable):f2}  ");

        }
    
}

void GetSumTable (int [,] arr)
{
    Console.WriteLine ($"Сумма чисел столбцов массива:");
    Console.WriteLine();

    for (int j = 0; j < arr.GetLength(1); j++)
        {
            double SumTable = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                SumTable += arr[i,j];
                
            }
            
            Console.Write ($" {SumTable}   ");

        }
    
}
