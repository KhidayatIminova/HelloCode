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
//Задача 2 (5)

int count = 0;
Console.Write ("Введите число:");
int number = int.Parse(Console.ReadLine ()); //по умолчанию считывает с консоли как string, преобразовываем в int
count = count - (number + 2);

while (count < number)
{
    count += 1;
    Console.Write (count + " " );
}


Console.Write ("\n\nВведите число:");
int number3 = int.Parse(Console.ReadLine ());

int x = number3 / 10;    // результат целое число без остатка
int y = number3 % 10;   // результат остаток
Console.WriteLine ($"последняя цифра {y}");
Console.WriteLine ($"{x}");

int B = -number3;  //- чтобы получить отрицательное число
Console.Write($"{number3} {B}"); //- знак $ позволяет 
Console.Write("\n\nЧисло " + number3 + " " + "Число " + B);