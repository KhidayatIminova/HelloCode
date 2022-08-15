// Написать программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру из числа (78 --> 8)

Console.Clear();

int num = new Random().Next(10,1000);
int a1 = num / 10;
int a2 = num % 100;
int a3 = a2 / 10;

int max = a1;
if (max < a2) max = a2;

Console.WriteLine(num);

Console.WriteLine($"a1 = {a1}");
Console.WriteLine($"a2 = {a2}");
Console.WriteLine($"a2 = {a3}");

Console.WriteLine(max);