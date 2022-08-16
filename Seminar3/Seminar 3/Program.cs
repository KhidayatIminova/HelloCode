// Задача 18. Написать программу, которая по заданному номеру четверти показывает диапазон возможных координат x и y
Console.Clear ();
Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

switch(num)
{
    case 1:
        Console.WriteLine("x>0 && y>0");
        break;
    case 2:
    Console.WriteLine("x<0 && y>0");
    break;
    default:
    
    Console.WriteLine("все остальные случаи");
    break;
    
}

//Задача Расстояние между двумя точками

Console.WriteLine("Введите Х1: ");

int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y1: ");

int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Х2: ");

int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2: ");

int y2 = int.Parse(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2,2));

Console.WriteLine($"c = {c:f4}");

//Задача. Таблица квадратов чисел

Console.Clear ();
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());
int k = num1;

if (num < 0) k = -num1;

for(int i=1; i<=k; i++)
{
    Console.WriteLine($"i={i} -> i*i={i*i}");
}