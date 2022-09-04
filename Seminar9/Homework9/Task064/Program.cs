// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 5, 6, 7, 8""

Console.Clear();

Console.Write($"Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write($"Введите N: ");
int n = int.Parse(Console.ReadLine());

int i = 0;       // для метода с пошаговым выводом рекурсии на экран

Console.WriteLine($"\nРяд чисел от {m} до {n}:   {GetNumbersRow(m,n)}\n");


// 1. Рекурсивный метод вывода ряда чисел в промежутке от M до N

string GetNumbersRow(int m, int n)
{
    if (m <= n) return $"{m} " + GetNumbersRow(m +1, n);
    else return String.Empty; // условие окончания
}


// // 2. С пошаговым выводом рекурсии на экран

// string GetNumbersRow(int m, int n)
// {
//     if (m <= n) 
//     {
//     Console.WriteLine($"Шаг рекурсии {i++} --> {m}");
//     return $"{m} " + GetNumbersRow(m +1, n);
    
//     }
//     else 
//     {
//         Console.WriteLine($"Шаг рекурсии {i++} --> {m} - базовый вариант.");
//         return String.Empty; // условие окончания
//     }
// }

