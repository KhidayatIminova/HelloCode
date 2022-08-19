Console.Clear();
// Задача 25. Написать  цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

// 1. Цикл For

double c = a;

if (b != 0)

{
    for (int i = 1; i < Math.Abs(b); i++)
    {
        if (b > 0)
        {
            c = c * a; // целая положительная степень (натуральная)
        }
        else 
        {
            c = c / a; // целая отрицательная степень
        }
    }
}

else c = 1; // нулевая степень


// 2. Без цикла

// double c = Convert.ToDouble(Math.Pow(a, b));

Console.WriteLine($"({a})^({b}) = {c} ");