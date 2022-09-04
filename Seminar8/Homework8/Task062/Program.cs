// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];  

//FillArray(array, 1, 10);           

PrintArray(array);  

//Fill1(array);
FillImage(array,0, 0);
Console.WriteLine();
PrintArray(array);  



// 1. Метод заполнения массива случайными целыми числами

// void FillArray(int[,] arr, int minValue, int maxValue)
// {

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(minValue, maxValue);

//         }
//     }
// }


// Метод спирального заполнения массива (по часовой стрелке)

void FillImage(int [,] arr, int row, int col) // в качестве аргумента берем позицию элемента, с которого начинаем закраску (внутри замкнутой области)
{
    int count = 1;
    if (array[row, col] == 0)       // если элемент равен нулю (не закрашен)
    {
        array[row, col] = count++;
        if (col < arr.GetLength(1)-1) 
        {FillImage(arr, row, col + 1); // затем в той же строке, но вправо ->
        array[row, col] = count++;}
        else if (row < arr.GetLength(0)-1) FillImage(arr, row + 1, col); // затем в тоv же столбце, но вниз v
        else if (col >= 1) FillImage(arr, row, col - 1); // затем в той же строке, но влево <-
        else if (row >= 0) FillImage(arr, row - 1, col); // сначала поднимаемся на строчку выше ^
        
               
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

// void Fill1(int [,] arr)
// {
//     int i = 0;
//     int count = 1;
//     for (i = 0; i< arr.GetLength(1); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1);j++)
//     {
//         arr[0, j] = count ++;
//         arr[i, arr.GetLength(1)-1] = count ++;
//     }        
//     }
        
// }