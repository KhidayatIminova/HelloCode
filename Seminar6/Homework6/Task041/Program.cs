// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

Console.Write("Сколько будет чисел? ");
int M = int.Parse(Console.ReadLine());

int [] array = GetArray(M);

PrintArray(array);
Console.WriteLine($"\nВсего введено чисел: {M} \nПоложительных чисел: {CountPos(array)}");
Console.WriteLine();

// 1. Метод заполнения массива с клавиатуры

int [] GetArray(int size) 
{
    int [] array = new int [size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-е число: "); 
        array[i] = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    return array;
}

// 2. Метод вывода массива на экран

void PrintArray(int [] arr)
{
    Console.Write("Введены числа: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

// 3. Метод, возвращающий значение счетчика положительных чисел

int CountPos(int [] arr) 
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0 || arr[i] == 0) continue;
            else count++;
                    }
        return count;
}

