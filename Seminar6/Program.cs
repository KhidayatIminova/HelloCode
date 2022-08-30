Console.Clear();

// Пошаговый разбор факториала

// int Factorial (int n)
// {
//     // При создании рекурсивной функции всегда должен быть некий базовый вариант, с которого начинается вычисление функции
//     if (n == 1) return 1; 
//     // Все рекурсивные вызовы должны обращаться к функции, которые в конце концов сходятся к базовому варианту
//     else return n * Factorial(n - 1);

// }

// Задача 39. Написать программу, которая перевернет одномерный массив (последний элемент будет на первом, а первый на последнем месте)
// [12345] -> [54321]

// 1. Сформировать массив случайных чисел

int [] array = GetArray(10, 0, 10);

PrintArray(array);
Console.WriteLine();

// 2. Первый алгоритм

int [] reverseArray = ReverseArray2(array);
Console.WriteLine(String.Join(" ", reverseArray));

// 3. Второй алгоритм

ReverseArray1(array);
Console.WriteLine(String.Join(" ", array));

//int [] array2 = GetReverse(array);

// PrintArray(array2);

int [] GetArray(int count, int minValue, int maxValue)
{
    int [] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
    Console.Write($"{arr[i]} ");
    }
}

// Алгоритм 1: копирование парных элементов

void ReverseArray1(int [] inArray)
{
    for (int i = 0; i < inArray.Length/2; i++)  // формируем цикл до середины массива (обходим как слева, так и справа (?))
    {   // для того, чтобы переписать парные элементы, необходимо один из них где-то сохранять
        int k = inArray[i]; // сохраняем текущий элемент в переменную k
        inArray[i] = inArray[inArray.Length - i -1]; // присваиваем правый крайний элемент крайнему левому. Значение в крайнем ktdjv элементе потеряно, но оно сохранено в k
        inArray[inArray.Length - i -1] = k; // присваиваем значение k правому крайнему элементу
    }
}

// Алгоритм 2. Формирование нового массива,
// который вернет перевернутый исходный массив
// Метод более простой, но избыточнее по ресурсам

int [] ReverseArray2 (int [] InArray)
{
    int [] result = new int[InArray.Length];  // внутри метода создаем новый массив result с привязкой к длине существующего (в качестве аргумента)

    for (int i = 0; i < InArray.Length; i++)
    {
        result[i] = InArray[InArray.Length - i -1];
    }

    return result;
}
// int [] GetReverse(int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr [arr.Length - i - 1];
//     }
//     return arr;
// }

// Задача 40. Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины
// (теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы длин двух других)



// Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101

int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Десятичное {num} в двоичное -> {Convert.ToString(num, 2)}");
Console.WriteLine();

// Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые 2 числа  Фибоначчи: 0 и 1.
// Если n = 5, то 0 1 1 2 3
// n = 7, 0 1 1 2 3 5 8 


// Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования