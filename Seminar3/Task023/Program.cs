// Задача 23.
// Написать программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear ();

Console.Clear ();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"Таблица кубов чисел от 1 до {num}");

int k = num;

if (num < 0) k = -num;

for(int i=1; i<=k; i++)
{
    Console.WriteLine($"i={i} -> i^3={Math.Pow(i,3)}");
}