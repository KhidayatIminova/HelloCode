﻿// Область видимости переменных

Console. Clear();

// int i = 5;

// Console.WriteLine($"Глобальная переменная i = {i}");

//PrintValue();

//Console.WriteLine($"Переменная i = {i}");

// void PrintValue()
// {
//     // Локальная переменная
//     int i = 50;
//     //int j;
//     Console.WriteLine($"Локальная переменная i = {i}");
    
//     // Начало контекста блока кода
//     {
//         j = 500;
//         Console.WriteLine($"Контекст блока кода j = {j}");
//     }
//     //Console.WriteLine($"Контекст блока кода j = {j}");   // при использовании j вне блока будет ошибка (при условии, что j определена в блоке кода. Если j определить за блоком, то ошибки не будет)
// }

// возвращаем переменную i из метода. В результате после выполнения метода, i принимает значение 50

// i = PrintValue();

// Console.WriteLine($"Переменная i = {i}");

// int PrintValue()
// {
//     // Локальная переменная
//     int i = 50;
//     //int j;
//     Console.WriteLine($"Локальная переменная i = {i}");
    
//     // Начало контекста блока кода
//     // {
//     //     j = 500;
//     //     Console.WriteLine($"Контекст блока кода j = {j}");
//     // }
//     //Console.WriteLine($"Контекст блока кода j = {j}");   // при использовании j вне блока будет ошибка (при условии, что j определена в блоке кода. Если j определить за блоком, то ошибки не будет)
//     return i;
// }

///////////////////////////////////////////////////

// Структура программы

////////////////////////////////////////

// 1. Глобальные переменные

// 2. Инструкции верхнего уровня. Вызов методов

// 3. Определения методов

///////////////////////////////////////////////////

// Архитектурные принципы создания методов

// Метод должен иметь только одну обязанность, не должен совмещать разные обязанности

// Возвращаемое значение метода основано только на его входных данных и не имеет никаких других зависимостей и воздействий на  всю программу


// Метод, который возвращает значение - функция


////////////////////

// Задача 31. Задать массив из 12 элементов, заполненный случайными числами из промежутка  [-9. +9]. Найти сумму отрицательных и сумму положительных элементов массива.

int [] array = GetArray(12, -9, +9);

Console.WriteLine(String.Join(" ,", array));
Console.WriteLine($"Сумма положительных чисел {GetPositiveSumm(array)}");
Console.WriteLine($"Сумма отрицательных чисел {GetNegativeSumm(array)}");

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

// 2. Получить сумму отрицательных элеиентов массива

int GetNegativeSumm(int [] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

// 3. Получить сумму положительных элементов массива

int GetPositiveSumm(int [] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}