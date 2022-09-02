// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.Write("Введите количество строк 1-й матрицы: ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1-й матрицы: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк 2-й матрицы: ");
int m2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2-й матрицы: ");
int n2 = int.Parse(Console.ReadLine());


// 1. Проверка на согласованность матриц

Console.WriteLine();
if (m1 != n2) Console.WriteLine($"Матрицы несовместимы. Умножение невозможно.");
//return;


int [,] matrix1 = GetArray(m1, n1, 1, 10);
int [,] matrix2 = GetArray(m2, n2, 1, 10);



// Console.Write("Введите размерность матриц: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите размерность матриц: ");
// int n = int.Parse(Console.ReadLine());

// int [,] matrix1 = GetArray(m, m, 1, 10);
// int [,] matrix2 = GetArray(m, m, 1, 10);

int [,] matrixMult = GetMatrixMultiply(matrix1, matrix2);

PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);

Console.WriteLine();
PrintArray(matrixMult);

// Метод перемножения матриц

int [,] GetMatrixMultiply(int [,] arr1, int [,] arr2)
{
    int [,] result = new int [arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                result[i, j] += arr1[i, k] * arr2[k, j];
            } 
        }
    }
    return result;
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
