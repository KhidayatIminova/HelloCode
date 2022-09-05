// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29 

// NOTE: в примере допущена ошибка, в действительности:  
// A(2,3) = 9 
// A(3,2) = 29

Console.Clear();

Console.Write($"Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write($"Введите N: ");
int n = int.Parse(Console.ReadLine());

int i = 0; // для метода с пошаговым выводом рекурсии на экран

Console.WriteLine($"A({m},{n}) = {GetAckermann(m, n)}");

// 1. Метод нахождения функции Аккермана для неотрицательных чисел m и n

int GetAckermann(int m, int n)
{
    if (m == 0) return n + 1;   // условие выхода: если m = 0

    else if (n == 0) return GetAckermann(m - 1, 1);   // (m > 0, n = 0)

    else return GetAckermann(m - 1, GetAckermann(m, n - 1));   // (m > 0, n > 0) 
}

// // 2. Функции Аккермана c пошаговым выводом рекурсии на экран

// int GetAckermann(int m, int n)
// {
//     if (m == 0) // условие выхода: если m = 0
//     {
//         Console.WriteLine($"Шаг рекурсии {i++} --> (m = 0): m = {m}, n = n + 1 = {n + 1} - базовый вариант.");
//         return n + 1;
//     }
//     else if (n == 0)    // (m > 0, n = 0)
//     {
//         Console.WriteLine($"Шаг рекурсии {i++} --> (m > 0, n = 0): m = {m}, n = {n}");
//         return GetAckermann(m - 1, 1);
//     }
//     else    // (m > 0, n > 0)
//     {
//         Console.WriteLine($"Шаг рекурсии {i++} --> (m > 0, n > 0): m = {m}, n = {n}");
//         return GetAckermann(m - 1, GetAckermann(m, n - 1));
//     }
// }
