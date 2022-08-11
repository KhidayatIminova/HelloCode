Console.Clear ();
Console.Write ("Введите число 1:");
int number1 = int.Parse(Console.ReadLine ()); //по умолчанию считывает с консоли как string, преобразовываем в int
Console.Write ("Введите число 2:");
int number2 = int.Parse(Console.ReadLine ());

if (number2 == number1 * number1)
{
    Console.WriteLine($"Квадрат числа {number1} равен числу {number2}");
}
else
{
    Console.WriteLine($"Число {number2} не является квадратом числа {number1}");
}
