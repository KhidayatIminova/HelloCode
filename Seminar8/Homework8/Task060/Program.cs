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

int[,,] array3x = GetArray(m, n, z);
PrintArray3x(array3x);


// 3. Метод, который возвращает трехмерный массив, заполненный неповторяющимися целыми числами

int[,,] GetArray(int row, int column, int zet)
{   
    int count = 10;
    int[,,] arr = new int[row, column, zet];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < zet; k++)
            {
            arr[i, j, k] = count++;
            }
        }
    }
    return arr;
}

// Метод вывода трёхмерного массива на экран

void PrintArray3x(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}