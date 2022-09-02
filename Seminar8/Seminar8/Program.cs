Console.Clear();

// // Массив с вещественными числами
// int m = 3;
// int n = 3;
// double [,] array = GetDoubleArray(m, n, 1, 10);

// double [,] GetDoubleArray(int m, int n, int min, int max)
// {
//     double [,] arr = new double [m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             arr[i,j] = min + new Random().NextDouble()*(max - min);
//         }
//     }
//     return arr;
// }

// Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine();

// int[,] array = GetArray(m, n, 1, 10);
// // проверка возможности замены строк на столбцы в задаче 55
// if (m != n) Console.WriteLine("Нельзя заменить строки на столбцы");
// return;

// int[,] arra = ChangeArray(array);
// PrintArray(array);
// Console.WriteLine();
// ChangeRows(array);
// PrintArray(array);
// Console.WriteLine();

// PrintArray(arra);


// // 1. Метод, возвращающий двумерный массив M x N, заполненный целыми числами

// int[,] GetArray(int row, int column, int minValue, int maxValue)
// {
//     int[,] arr = new int[row, column];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return arr;
// }

// // 2. Метод вывод массива на экран

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"  {arr[i, j]} | ");
//         }
//         Console.WriteLine();
//     }
// }

// // 3. Метод замены первой и последней строк
// // Идея метода: нужно сохранить значение в какой-то временной переменной, потом присвоить одно значение другому. По всем столбцам поменять значения в первой строке со значениями в последней
// void ChangeRows(int [,] inArray)
// {
//     int rowCount = inArray.GetLength(0) - 1;        // последняя строка
//     for (int i = 0; i < inArray.GetLength(1); i++)  // по всем колонкам
//     {
//         int k = inArray[0,i];                       // сохраняем во временной переменной значения в первой строке (нулевая)
//         inArray[0,i] = inArray[rowCount, i];        // копируем из последней строки в первую строку значения
//         inArray[rowCount, i] = k;                   // копируем в последнюю строку значения из временной переменной
//     }
// }


// // Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщениее для пользователя.

// // 4. Метод замены строк на столбцы
// // Берем за основу метод распечатки массива PrintArray()

// int [,] ChangeArray(int[,] arr)
// {
//     int [,] result = new int [arr.GetLength(0), arr.GetLength(1)];  // создаем внутри метода массив result размером равным размеру входного массива arr
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             result[j, i] = arr[i,j];     // для каждого столбца нового массива копируем значение строки
//         }
//         Console.WriteLine();
//     }
//     return result;
// }

// // Задача 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// int [] array1 = new int [7];

// // Метод пузырьковой сортировки
// void SortArray (int [] arr)
// {
//     // 4, 5, 2, 7, 1, 9
//     for (int i = 0; i < arr.Length; i++)     //  берем цифру 4 (для i = 0)
//     {
//         for (int j = 0; j < arr.Length; j++)
//         {
//             if (arr[i] > arr[j])            // и сравниваем с другими элементами
//             {
//                 int k = arr[i];             // в случае когда 4 > 2 (элемент с индексом 2) пишем значение 4 во временнуб переменную k
//                 arr[i] = arr [j];           // в индекс 0 пишем значение 2
//                 arr [j] = k;                // в индекс 2 пишем значение 4
//             }
//                                             // и т.д.
//         }
//         Console.WriteLine();
//     }
// }

// // метод подсчета элементов (при условии, что массив осортирован (почему?))
// void PrintData(int [] arr)
// {
//     int num = arr [0];                      // начинаем с элемента с индексом 0
//     int count = 1;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == num)                  // если текущее значение элемента равно 
//         {
//             count++;                        // то счетчик увеличивается
//         }
//         else
//         Console.WriteLine($"Число {num} встречается {count} раз");  // иначе выводим сообщение
//         count = 1;                          // счетчик в исходное состояние
//         num = arr[i];                       // и задаем новое значение num
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int[,] array = GetArray(m, n, 1, 10);
// PrintArray(array);
// int [] arrayLine = GetRowArray1(array);
// SortArray(arrayLine);
// PrintArray1(arrayLine);
// PrintData(arrayLine);

// // Метод получения линейного массива из двумерного

// int [] GetRowArray1(int [,] arr)
// {
//     int [] result = new int [arr.GetLength(0)*arr.GetLength(1)];
//     int index = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)     //  берем цифру 4 (для i = 0)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//         result[index++] = arr[i,j];    // для каждого элемента                     
//         }
        
//     }
//     return result;
// }

// void PrintArray1(int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"  {arr[i]} | ");
        
//     }
// }

// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// 9 4 2
// 2 2 6 
// 3 4 7

// Решение: 
// 1. Написать метод поиска наименьшего элемента
// 2. Написать метод формирования меньшего массива из большего

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = GetArray(m, n, 1, 10);
PrintArray(array);

// Находим позицию минимального значения

int [] indx = GetMinElement(array);


// Исключаем строку и столбец с минимальным элементом

int [,] outArray = GetResultArray(array, indx);
PrintArray(outArray);

// 1. Метод, возвращающий двумерный массив M x N, заполненный целыми числами

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return arr;
}





// 2. Метод вывод массива на экран

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"  {arr[i, j]} | ");
        }
        Console.WriteLine();
    }
}

// 3. Поиск наименьшего

int [] GetMinElement(int [,] arr)
{
    int [] result = new int[] {0,0};    // начальное значение элемента
    int min = arr[0, 0];
    
    for (int i = 0; i < arr.GetLength(0); i++)     //  берем цифру 4 (для i = 0)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        if (min > arr[i, j])
        {
            min = arr[i, j];
            result[0] = i;
            result[1] = j;
        }                     
        }
        
    }
    return result;
}

// 4. Исключение строки и столбца по индексам наименьшего элемента

int [,] GetResultArray(int [,] arr, int [] indexes) // входные параметры: массив и координаты минимального элемента
{
    int [,] result = new int [arr.GetLength(0)-1, arr.GetLength(1)-1];
    int row = 0, col = 0;
    for (int i = 0; i < arr.GetLength(0); i++)     //  берем цифру 4 (для i = 0)
    {
        if (i == indexes[0]) continue;              // если индекс строки равен индексу минимального элемента, то эту строку пропускаем
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == indexes[0]) continue;              // если индекс столбца равен индексу минимального элемента, то этот столбец пропускаем
            result[row,col] = arr[i,j];
            col++;
            }                     
        row++;
    }
    return result;
}