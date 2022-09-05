// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.WriteLine("Параметры трёхмерного массива:\n");
Console.Write("Введите размер 1: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите размер 2: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите размер 3: ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,,] array3x = GetArray(x, y, z);
PrintArray3x(array3x);

// 1. Метод, который возвращает трехмерный массив, заполненный неповторяющимися целыми числами

int[,,] GetArray(int size1, int size2, int size3)
{
    int number = 10;
    int[,,] arr = new int[size1, size2, size3];
    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                arr[i, j, k] = number++;
            }
        }
    }
    return arr;
}

// 2. Метод вывода трёхмерного массива на экран с указанием индекса элемента

void PrintArray3x(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}