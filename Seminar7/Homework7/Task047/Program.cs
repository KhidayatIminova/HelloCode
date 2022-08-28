// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();


int m = 3;
int n = 4;

double [,] array = new double [3, 4];

int a = 1;
int b = 10;


// PrintArray(array);
// Console.WriteLine();
FillArray(array, a, b);
PrintArray(array);


void FillArray(double [,] arr, int minValue, int maxValue)
{
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 1);
            
        }
    }
}

void PrintArray(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} | ");
        }
        Console.WriteLine();
    }
}

