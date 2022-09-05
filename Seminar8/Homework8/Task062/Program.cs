// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.Write("Введите размерность матрицы: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] matrix = new int[n, n];

FillMatrix(matrix);
PrintArray(matrix);

// 1. Метод спирального заполнения квадратной матрицы (по часовой стрелке)

void FillMatrix(int[,] arr)
{
    int i = 0;
    int j = 0;
    int k = 0;
    int number = 10;

    if (n == 1) arr[i, j] = 99; // если размер матрицы равен 1, то спиральное заполнение не применяем

    for (int n = arr.GetLength(0); n > 1; n = n - 2)    // поскольку за 1 цикл заполняются 2 строки/2 столбца, декремент n уменьшаем на 2
    {
        for (k = 0; k < n - 1; k++) matrix[i, j++] = number++;   // двигаемся вправо до n - 1
        for (k = 0; k < n - 1; k++) matrix[i++, j] = number++;   // двигаемся вниз до n - 1
        for (k = 0; k < n - 1; k++) matrix[i, j--] = number++;   // двигаемся влево до n - 1
        for (k = 0; k < n - 1; k++) matrix[i--, j] = number++;   // двигаемся вверх до n - 1
        i++;
        j++;
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



