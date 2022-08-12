// Семинар 1. Задача 2
// Написать программу, которая принимает на вход 2 числа и выдает, какое большее, а какое меньшее 

Console.Clear ();

Console.Write ("Введите число a: ");
int a = int.Parse(Console.ReadLine ()); 
Console.Write ("Введите число b :");
int b = int.Parse(Console.ReadLine ());

if (a > b)  
{
    Console.WriteLine ($"\na = {a}; b = {b}  ->  max = {a}   (a > b)");
}

else
    if (a < b)
    {
    Console.WriteLine ($"\na = {a}; b = {b}  ->  max = {b}   (a < b)");
    }

else
{
    Console.WriteLine ("\nЧисла a и b равны   (a = b)");
}