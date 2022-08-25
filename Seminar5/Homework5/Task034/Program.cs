// Задача 34.
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

Console.Clear();

int [] array = GetArray(4, 1, 999);

Console.WriteLine($"[{string.Join(" ,",array)}]");
Console.Write($"Количество четных чисел ");
PrintEvenElements(array);
Console.WriteLine($"в массиве = {GetCountEvenElements(array)}");

// 1. Метод, который возвращает массив, заполненный случайными числами из заданного промежутка

int [] GetArray(int count, int minValue, int maxValue)
{
    int [] array = new int [count];

    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

// 2. Метод, который возвращает количество элементов с четными числами

int GetCountEvenElements(int [] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {   
        if (arr[i]%2 != 0) continue;
        
        else count++;
    }
    return count;
}
// 3. Метод вывода на экран четных элементов массива

void PrintEvenElements(int [] arr)
{
        for (int i = 0; i < arr.Length; i++)
    {   
        if (arr[i]%2 != 0) continue;
        //        Console.Write($"[{arr[i]}] ");
        else Console.Write($" [{arr[i]}] ");
    }
}