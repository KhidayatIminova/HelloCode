// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество z: ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = GetArray(m, n, z, 1, 10);
int [] arr = GetRowArray1(array);
PrintArray(array);
PrintArray1(arr);

// 3. Метод, который возвращает трехмерный массив, заполненный неповторяющимися целыми числами

int[,,] GetArray(int row, int column, int zzz, int minValue, int maxValue)
{   
    int count = 10;
    int[,,] arr = new int[row, column, zzz];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < zzz)
            arr[i, j, k] = count++;
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

// Метод получения двумерного массива из линейного

int [,] GetRowArray1(int [,,] arr)
{
    int [,] result = new int [arr.GetLength(0)*arr.GetLength(1), arr.GetLength(1)*arr.GetLength(2)];
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)     //  берем цифру 4 (для i = 0)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        result[index++] = arr[i,j];    // для каждого элемента                     
        }
        
    }
    return result;
}

void PrintArray1(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"  {arr[i]} | ");
        
    }
}