// Методы

Console.Clear();

// Вид 1

void Method1()
{
    Console.WriteLine("Автор...");
}

Method1();

// Вид 2

void Method2(string msg)  // Метод, который ничего не возвращает, но в то же время может принимать какие-то аргументы
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)  // Метод, который ничего не возвращает, но в то же время может принимать какие-то аргументы
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;       // увеличение на 1 (инкремент)                 (уменьшение на 1 - декремент)
    }
}
// Method21("Текст",4); // Сколько раз хотим увидеть текст сообщения
// Method21(msg: "можно еще вот так",count: 4);
Method21(count: 4, msg: "или вот так");
// Note: при зацикливании программы Ctrl-C в помощь )


// Вид 3    Метод, который что-то возвращает, но ничего не принимает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4. Метод, который что-то принимает и что-то возвращает

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;   // переменная, куда будем класть результат. Изначальное значение - пустая строка
//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10,"asdf ");
// Console.WriteLine(res);


// то же, но через for

// string Method4(int count, string c)
// {
//     string result = String.Empty;   // переменная, куда будем класть результат. Изначальное значение - пустая строка
//     for (int i = 0; i < count; i++)
//     {
//         result = result + c;
//     }
//     return result;
// }
// string res = Method4(10,"asdf ");
// Console.WriteLine(res);

// Цикл в цикле

// Вывод таблицы умножения на экран

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");   // $ - интерполяция строк
//     }
//     Console.WriteLine();

// }

// Работа с текстом.
// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие буквы "С" заменить на маленькие "с"

// string text = "- Я думаю, сказал князь, улыбаясь - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"     Для того, чтобы обратиться к конкретному символу строки, используем номер символа
// //             012345
// // s[3] // r - третий символ   

// string Replace(string text, char OldValue, char NewValue)
// {
//     string result = String.Empty;
//     int length = text.Length; // кол-во символов строки
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == OldValue) result = result + $"{NewValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;

// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text,'с','С');
// Console.WriteLine(newText);
// Console.WriteLine();

///////////////////////////////////////////////////

// Сортировка массива

// Метод перебора

// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен  этого значения со значением первой неотсортированной позиции
// 3. Повторять, пока есть неосортированные элементы

int [] arr = { 3, 5, 6, 3, 1 ,8 , 8, 4 ,5 ,7 ,8 };

void PrintArray(int [] array)
{   
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++) // array.Length - 1 нужно для того, чтобы работал цикл j
    {
        int minPosition = i; // определяем позицию, на которую смотрим и запоминаем ту самую позицию рабочего элемента, для которого в дальнейшем будем производить какие-то действия
        for (int j = i + 1; j < array.Length; j++)  // то, что уже было отсортировано того не касаемся, а неотсортированная часть начинается с позиции i + 1
        {
            if (array[j] < array[minPosition]) minPosition = j; // если элемент меньше предполагаемого минимальным, то позицию элемента сохраняем
        }
        int temporary = array[i];

        array[i] = array[minPosition];        // простой обмен двух переменных местами
        array[minPosition] = temporary;         // в минимальную позицию кладем элемент, который был временным

    }
    Console.WriteLine();
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);