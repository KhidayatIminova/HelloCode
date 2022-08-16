﻿// Семинар 2. Задача 10
// которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear ();

//1. Через генератор случайных чисел
// int a = new Random().Next(-1000000,1000000);

//2. Или через терминал
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int i = 1; // задаем счетчик

while (i > 0)
{
int b = a / Convert.ToInt32(Math.Pow(10, i));  // считаем количество цифр в числе: делим число на 10 i раз, пока не получится 0
    if (b == 0)
    break;      // при достижении нуля выходим из цикла
i++;
}
Console.WriteLine ($"Число {a} содержит {i} цифр(ы) "); // выводим результат счетчика

if (i < 3)
{
    Console.WriteLine ($"\nТретьей цифры в числе {a} нет");
}
else
{
    // Находим третью цифру: сначала получаем трехзначное число (делим число a на 10 в степени (i-3)). 
    //Затем находим остаток этого числа (% 10) и его модуль, если число отрицательное
    
    int result3 = Math.Abs(a / Convert.ToInt32(Math.Pow(10, i-3))) % 10;    
    Console.WriteLine ($"\nТретья цифра числа {a} --> {result3}");
}
