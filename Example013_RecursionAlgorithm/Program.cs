Console.Clear();

// string[,] table = new string[2, 5];

// // Инициализация для строк производится при помощи String.Empty
// // table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// // table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]

// // для того, чтобы обратиться к нужному элементу:

// table [1, 2] = "слово";

// for (int rows = 0; rows < 2; rows ++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

// int [,] matrix = new int[3, 4];
// for (int rows = 0; rows < 3; rows ++)
// {
//     for (int columns = 0; columns < 4; columns++)
//     {
//         Console.Write($"{matrix[rows, columns]} ");
//     }
//     Console.WriteLine();
// }



// void FillArray(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i ++)      //  matrix.GetLength(0) - получить кол-во строк
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)   //  matrix.GetLength(1) - получить кол-во столбцов
//         {
//             matr[i, j] = new Random().Next(1, 10); // [1, 10)
//         }
//     }
// }

// void PrintArray(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i ++)      //  matrix.GetLength(0) - получить кол-во строк
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)   //  matrix.GetLength(1) - получить кол-во столбцов
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] matrix = new int[3, 4];

// PrintArray(matrix);
// Console.WriteLine();
// FillArray(matrix);
// PrintArray(matrix);


// int[,]pic = new int[23, 25]
// 0 - закрашенный пиксель
// 1 - незакрашенный

// как закрасить область?

int [,] pic = new int [,]  // необязательно указывать количество строчек и столбцов, если есть фиксированные данные
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,},
    {0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0,},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0,},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0,},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0,},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0,},
    {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0,},
    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0,},
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0,},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0,},
    {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0,},
    {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0,},
    {0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,},
    {0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,},
    {0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,},
    {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,},

};

void PrintImage(int [,] image)
{
    for (int i = 0; i < image.GetLength(0); i ++)      //  matrix.GetLength(0) - получить кол-во строк
    {
        for (int j = 0; j < image.GetLength(1); j++)   //  matrix.GetLength(1) - получить кол-во столбцов
        {
            //Console.Write($"{image[i, j]} ");
            if (image[i,j] == 0) Console.Write(" "); // если элемент равен 0, то печатаем пробел " "
            else Console.Write("+");
        }
        Console.WriteLine();
    }
}

PrintImage(pic);
FillImage(5,5);
PrintImage(pic);

// Метод закрашивания

void FillImage(int row, int col) // в качестве аргумента берем позицию элемента, с которого начинаем закраску (внутри замкнутой области)
{
    if (pic[row, col] == 0)       // если элемент равен нулю (не закрашен)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col); // сначала поднимаемся на строчку выше ^
        FillImage(row, col - 1); // затем в той же строке, но влево <-
        FillImage(row + 1, col); // затем в тоv же столбце, но вниз v
        FillImage(row, col + 1); // затем в той же строке, но вправо ->
    }
}

// Рекурсия - метод, который вызывает сам себя

// Факториал
// 5! = 1*2*3*4*5
// 5! = 5 * 4!

// Метод, который принимает число и возвращает факториал этого числа

// int Faktorial (int n)
// {
//     // note: 1! = 1, 0! = 1

//     if (n == 1) return n = 1;   // если дошли до 1, то вернуть 1
//     else return n * Faktorial (n - 1);  // иначе вернуть (текущее значение n умноженное на факториал предыдущего числа)
// }

// Console.WriteLine(Faktorial(4));

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Faktorial(i)}"); // пример переполнения типа данных int
// }

// double Faktorial (int n)
// {
//     // note: 1! = 1, 0! = 1

//     if (n == 1) return n = 1;   // если дошли до 1, то вернуть 1
//     else return n * Faktorial (n - 1);  // иначе вернуть (текущее значение n умноженное на факториал предыдущего числа)
// }

// Console.WriteLine(Faktorial(4));

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Faktorial(i)}"); // типа данных double позволяет вывести корректно
// }

///// Фибоначчи
///// f(1) = 1
////  F(2) = 1
////  f(n) = f(n-1) + f(n-2)

// int Fibonacci(int n)
// {
//     if (n ==1 || n ==2) return n=1; // если n равно 1 или 2, то возвращаем 1
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 15; i++)
// {
//     Console.Write($" {Fibonacci(i)}"); 
// }


////