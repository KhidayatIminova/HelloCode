// Задача 36.
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19

Console.Clear();

int [] array = GetArray(10, 1, 25);

Console.WriteLine($"[{string.Join(" ,",array)}]");
PrintOddIndex(array);
Console.WriteLine($"{GetSumOddIndex(array)}");

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

// 2. Метод, который возвращает сумму элементов с нечетными индексами

int GetSumOddIndex(int [] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i=i+2)
    {   
            sum += arr[i];
    }
    return sum;
}

// 3. Метод вывода на экран элементов с нечетными индексами

void PrintOddIndex(int [] arr)
{
            Console.Write($"Сумма элементов с нечетными индексами: {arr[1]}");

    for (int i = 3; i < arr.Length; i=i+2)
    {   
            Console.Write($" + ");
            Console.Write($"{arr[i]}");
    }
    Console.Write($" = ");
}