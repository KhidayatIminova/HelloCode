// Задача 38.
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int size = 5;
int b = 0;
int c = 99;

double [] array = GetArray(size, b, c);

double max = FindMaxElement(array, b);
double min = FindMinElement(array, c);

Console.WriteLine($"[{string.Join(" | ", array)}]");
Console.WriteLine($"\nМинимальный элемент  = {FindMinElement(array, c)}");
Console.WriteLine($"Максимальный элемент = {FindMaxElement(array, b)}");
Console.WriteLine($"\ni (max) - i (min) = {max} - {min} = {(max - min):f2}");
Console.WriteLine();

// 1. Метод, который возвращает массив, заполненный случайными вещественными числами из заданного промежутка

double [] GetArray(int count, int minValue, int maxValue)
{
     double [] array = new double [count];

     for (int i = 0; i < count; i++)
     {
         array[i] = new Random().Next(minValue, maxValue) + (new Random().NextDouble());
         array[i] = Math.Round(array[i], 2);   // округляем до 2-х знаков после запятой
     }
     return array;
}

// 2. Метод, который возвращает максимальное значение элемента

double FindMaxElement(double [] arr, double minValue)

{
    double max = minValue;   //   привязка к мнимальному значению диапазона

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

// 3. Метод, который возвращает минимальное значение элемента

double FindMinElement(double [] arr, double maxValue)

{
    double min = maxValue;   //   привязка к максимальному значению диапазона

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}