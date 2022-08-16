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

//Задача 11
//Написать программу, которая выводит случайное трёхзначное число и удаляет вторую цифру из этого числа

Console.WriteLine();

int num1 = new Random().Next(10,1000);

int result = (num1 / 100) * 10 + num1 % 10;

Console.WriteLine(num1);
Console.WriteLine(result);

// Задача 12. Написать программу, которая будет принимать на вход 2 числа и выводить, является ли второе число кратным первому. Если не является, то программа выводит остаток от деления.
// 
Console.WriteLine();
Console.WriteLine("Введите 1-е число: ");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int b2 = int.Parse(Console.ReadLine());

if (b1 % b2 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно. Остаток - {b1 % b2}");   
}


// Условный оператор

Console.WriteLine();

string answer = b1 % b2 == 0 ? "Кратно" : $"Не кратно, остаток - {b1 % b2}";
Console.WriteLine(answer);

//Задача 14.
// Написать программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine();
Console.WriteLine("Введите число: ");
int c = int.Parse(Console.ReadLine());

int c7 = c % 7;
int c23 = c % 23;

string answer1 = c7 ==0 && c23 == 0 ? "Кратно" : $"Не кратно"; // && - логический оператор "ИЛИ"
Console.WriteLine(answer1);

//Задача 16.
// Написать программу, которая принимает на вход 2 числа и проверяет, является ли одно число квадратом другого
// 5, 25 --> Да

Console.WriteLine();

Console.WriteLine("Введите число d1: ");
int d1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число d2: ");
int d2 = int.Parse(Console.ReadLine());

if (d1 * d1 == d2)
{
    Console.WriteLine("d2 является квадратом d1");
    return; // если условие выполнено, то действие программы завершается (break - выход из блока цикла, выполнение программы передается за пределы блока цикла. Return - прекращает выполнение программы)
}
if (Math.Pow(d2, 2) == d1)
{
    Console.WriteLine("d1 является квадратом d2");
}
else
{
    Console.WriteLine("Не является");
}
Console.WriteLine();

// Пример использование break:

int num3 = 1;

while (num3 < 10)
{
    if (num3 == 5)
    
    break;
       
    num3++;
}