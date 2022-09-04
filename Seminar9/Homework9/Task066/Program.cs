// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write($"Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write($"Введите N: ");
int n = int.Parse(Console.ReadLine());

int i = 0; // для метода с пошаговым выводом рекурсии на экран

Console.WriteLine($"\nСумма элементов от {m} до {n} = {GetSum(n, m)}\n");


// 1. Рекурсивный метод нахождения суммы элементов в промежутке от M до N

int GetSum(int n, int m)

{
    if (n == m) return m; // условие выхода: если n == m
    else n = n + GetSum(n - 1, m);
    return n;
}

//// 2. С пошаговым выводом рекурсии на экран

// int GetSum(int n, int m)

// {
//     if (n == m) // условие выхода: если n == m
//     {
//         Console.WriteLine($"Шаг рекурсии {i++} --> n = {m} - базовый вариант.");
//         return m; // условие выхода: если n == m
//     }
//     else
//     {
//         Console.WriteLine($"Шаг рекурсии {i++} --> n = {n}");
//         n = n + GetSum(n - 1, m);
//         return n;
//     }
// }