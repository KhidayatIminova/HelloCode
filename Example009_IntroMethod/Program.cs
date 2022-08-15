Console.Clear();
//метод - сравниваются по тройки "игроков", затем "финал победителей"
int Max(int arg1, int arg2, int arg3)
{ //тело метода
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0   1   2   3   4   5   6   7   8
int[] array = {16, 27, 83, 94, 53, 62, 745, 86, 89};

array[0] = 12; // присвоить элементу с индексом 0 значение 12 (было 16, стало 12)
Console.WriteLine(array[4]); // вывести на экран элемент с индексом 4


// int max1 = Max (a1, b1, c1); //для определения "3-х финалистов" создадим переменную max1 и скажем, чторезультатом работы функции Max будет являться максимальное из 3-х чисел a1, b1, c1
// int max2 = Max (a2, b2, c2);
// int max3 = Max (a3, b3, c3);
// int max = Max (max1, max2, max3);

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );

Console.WriteLine(max);
