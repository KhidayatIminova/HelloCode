// Задача 21.
// Написать программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84

Console.Clear ();

Console.Write("Введите Х1: ");

int x1 = int.Parse(Console.ReadLine());

Console.Write("Введите Y1: ");

int y1 = int.Parse(Console.ReadLine());

Console.Write("Введите Z1: ");

int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите Х2: ");

int x2 = int.Parse(Console.ReadLine());

Console.Write("Введите Y2: ");

int y2 = int.Parse(Console.ReadLine());

Console.Write("Введите Z2: ");

int z2 = int.Parse(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2));

Console.WriteLine($"c = {c:f2}");