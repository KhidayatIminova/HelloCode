// Семинар 2. Задача 15
// Написать программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear ();

Console.Write("Введите цифру, обозначающую день недели (от 1 до 7): ");
int day = int.Parse(Console.ReadLine());

if (day < 1 || day >7)
{
    Console.WriteLine($"\nЧисло {day} находится вне допустимого диапазона");
    return;  
}
string answer = day > 0 && day < 6 ? "Рабочий день" : $"Выходной";

Console.WriteLine(answer);