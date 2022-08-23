﻿// // Универсальный алгоритм проверки на палиндром (не только число)

// Console.Clear();
// Console.WriteLine("Введите строку: ");
// string sNum = Console.ReadLine();  // определяем sNum как string
// // Note 1: функция ReadLine возвращает строку. При необходимости в int выполняется преобразование через Parse в целое число. Здесь этого не требуется 
// // Note 2: со строкой можно работать как с массивом

// int lenght = sNum.Length; // длина строки

// for (int i = 0; i<lenght / 2; i++)  // от 0 до половины длины строки
// {
//     if(sNum[i] != sNum[lenght - 1 - i])  // сравниваем пары символов, например при lenght=5 и при i=0 сравнивается нулевой символ строки и (5 -1 - 0)=4-й (последний)
    
//     //Note: !=   означает "не равно"
//     {
//         Console.WriteLine($"Строка {sNum} не палиндром");
//         return;
//     }
// }

// Console.WriteLine($"Строка {sNum} палиндром");

Console.Clear();

// Console.WriteLine("Введите строку: ");
// string sNum = Console.ReadLine();  // определяем sNum как string
// // Note 1: функция ReadLine возвращает строку. При необходимости в int выполняется преобразование через Parse в целое число. Здесь этого не требуется 
// // Note 2: со строкой можно работать как с массивом

// int lenght = sNum.Length; // длина строки

// for (int i = 0; i<lenght; i++)  // 
// {
//     if(sNum[i] == '1')  // если в строке есть символ 1
    
//     {
//         //continue; // то мы его пропустим (continue начинает новую итерацию)
//         break; // прекращает выполнение цикла
//     }
// Console.WriteLine($"{i} символ {sNum[i]}");
// }

// Задача 24.Написать программу, которая принимает на вход число А и выдает сумму чисел (цифр!) от 1 до А
// 47 --> 11

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());  

// // опишем метод (GetSum), который возвращает сумму цифр

// Console.WriteLine(GetSum(num));

// string str = num.ToString();
// Console.WriteLine($"число {num} и строка {str}");                                // чтобы получить из целого числа его строковое представление достаточно выполнить .ToString()

// int GetSum(int number)
// {

// int sum = 0;

// while (number>0) // пока число больше нуля
// {
// sum += number % 10; // каждое правое число будем получать путем получения деления остатка и прибавлять его к сумме
// number /=10; // следующим шагом делим number  на 10
// }
// return sum;
// }

// Задача 26. Написать программу, которая принимает на вход число и выдает количество элементов в числе

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());  

// Console.WriteLine(GetCount(num));

// int GetCount(int number)  // опишем функцию подсчета чисел
// {

// int Count = 0;

// while (number>0) // пока число больше нуля
// {
// Count ++; // каждое правое число будем получать путем получения деления остатка и прибавлять его к сумме
// number /=10; // следующим шагом делим number  на 10
// }
// return Count; // и вернем результат
// }


// Задача 28. Написать программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

  

// // опишем метод (GetMult), который возвращает произведение цифр


// int GetMult(int number)
// {

// int result = 1;
// for (int i = 1; i <= number; i++)
// {
//     result *= i;  // последовательно перемножаем числа
// }

// return result;
// }
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine(GetMult(num));

// Задача 30. Написать программу, которая выводит на экран массив из 8 элементов, заполненный нулями и единицами в случайном порядке

int [] array = GetBinArray(8);  // создаем массив из 8 элементов

int [] GetBinArray(int size) // определяем функцию (метод), в которой создаем и возвращаем массив
{
    int [] arr = new int [size]; // определим внутри функции массив, куда будут записываться результаты (назовем его arr) и укажем размер через формальный параметр size
                                    // получим пустой массив, который надобудет вернуть
    
    int i = new Random().Next(2);  // заполняем массив случайными числами. Когда у функции Next только один параметр - предел размерности числа (предел 2: число не входит)
    
    for (i = 0; i < size; i++)  // добавляем цикл
    {
        arr[i] = new Random().Next(2);
    }

    return arr;
}

// Вывод на экран
// 1-й вариант

// Console.WriteLine("Массив случайных чисел");
// for (int i =0; i < array.Length; i++)
// {
//     Console.Write(array[i]);
// }

// 2-й вариант

Console.WriteLine($"[{string.Join(" , ", array)}]");