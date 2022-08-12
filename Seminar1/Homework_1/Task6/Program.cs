// Семинар 1. Задача 6
// Написать программу, которая принимает на вход число и выдает, является ли число четным  (делится ли оно на два без остатка)

Console.Clear ();

Console.Write ("Введите число: ");
int a = int.Parse(Console.ReadLine ()); 

if (a == 0)
{
    Console.WriteLine ($"\nЧисло {a}  -  не является ни четным, ни нечетным");  
}
else
{
    if (a % 2 == 0)
    {
        Console.WriteLine ($"\nЧисло {a}  -  четное");
    }
    else
    {
        Console.WriteLine ($"\nЧисло {a}  -  нечетное");
    }
}

