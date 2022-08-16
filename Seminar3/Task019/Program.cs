// Семинар 3. Задача 19
// Написать программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear ();

//1. Через генератор случайных чисел
// int a = new Random().Next(-10000,10000);

//2. Или через терминал
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int a5 = a % 10;
int a4 = (a / 10) % 10;
int a3 = (a / 100) % 10;
int a2 = (a / 1000) % 10;
int a1 = (a / 10000) % 10;

string answer = a1 == a5 && a2 == a4 ? "Палиндром" : $"Не палиндром";

Console.WriteLine(a);
Console.WriteLine(answer);
Console.WriteLine($"{a1}{a2}{a3}{a4}{a5}");