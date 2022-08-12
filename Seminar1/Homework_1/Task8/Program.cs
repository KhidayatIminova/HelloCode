// Семинар 1. Задача 8
// Написать программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear ();

Console.Write ("Введите число (N > 1): ");
int N = int.Parse(Console.ReadLine ()); 

if (N <= 1)
{
    Console.WriteLine ($"\nЧисло {N}  находится вне допустимого диапазона");  
}
else
{
    int count = 2;
    Console.Write ($"\nЧётные числа от 1 до {N}:");

    while (count < N)
    {
        Console.Write ($" {count} "); 
        count += 2;
    }
}
Console.WriteLine ("\n ");