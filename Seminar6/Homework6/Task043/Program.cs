// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("Введите k1: ");
int K1 = int.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
int B1 = int.Parse(Console.ReadLine());

Console.Write("Введите k2: ");
int K2 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
int B2 = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine($"Уравнение прямой 1:   y = {K1} * x + {B1}");
Console.WriteLine($"Уравнение прямой 2:   y = {K2} * x + {B2}");

CheckCrossLine(K1, B1, K2, B2);
Console.WriteLine();

// 1. Метод проверки на параллельность с вызовом метода расчета точки пересечения

void CheckCrossLine(double k1, double b1, double k2, double b2)
{
    if (k1 != k2) 
    {
        Console.Write("\nПрямые 1 и 2 пересекаются ");
        GetCrossPoint(k1, b1, k2, b2);
    }
    else if (k1 == k2 && b1 != b2) Console.WriteLine("\nПрямые 1 и 2 параллельны");
    else if (k1 == k2 && b1 == b2) Console.WriteLine("\nПрямые 1 и 2 совпадают");
}

// 2. Метод расчета точки пересечения

void GetCrossPoint(double k1, double b1, double k2, double b2)
{
    double crossX = (b2 - b1)/(k1 - k2);
    double crossY = (k1 * crossX + b1);
    Console.WriteLine($"в точке с координатами ({crossX:f2};{crossY:f2})");
}