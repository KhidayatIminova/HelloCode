// Задача 38.
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int a = 5;
int b = 0;
int c = 99;

//double [] array = new double [a];

double [] array = GetArray(a, b, c);

double max = FindMaxElement(array, b);
double min = FindMinElement(array, c);


Console.WriteLine($"[{string.Join(" ,", array)}]");
Console.WriteLine($"i (max) - i (min) = {max} - {min} = {max - min}");


//double FindMax(int i, )

// int [] array = GetArray(12, -9, +9);

// Console.WriteLine(String.Join(" ,", array));
// Console.WriteLine($"Сумма положительных чисел {GetPositiveSumm(array)}");
Console.WriteLine($"Максимальный элемент {FindMaxElement(array, b)}");
Console.WriteLine($"Минимальный элемент {FindMinElement(array, c)}");

// 1. Метод, который возвращает массив, заполненный случайными числами из заданного промежутка

double [] GetArray(int count, int minValue, int maxValue)
{
     double [] array = new double [count];

     for (int i = 0; i < count; i++)
     {
         array[i] = new Random().Next(minValue, maxValue + 1);
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
    double min = maxValue;   //   привязка к мнимальному значению диапазона

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}