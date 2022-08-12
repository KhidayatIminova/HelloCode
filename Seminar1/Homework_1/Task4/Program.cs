// Семинар 1. Задача 4
// Написать программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел 

Console.Clear ();

Console.Write ("Введите число a: ");
int a = int.Parse(Console.ReadLine ()); 
Console.Write ("Введите число b :");
int b = int.Parse(Console.ReadLine ());
Console.Write ("Введите число c :");
int c = int.Parse(Console.ReadLine ());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine ($"\na = {a}; b = {b}; c = {c}  Максимальное значение ->  max = {max}");