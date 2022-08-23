Console.Clear();
// Задача 27. Написать  программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());  

Console.WriteLine(GetSum(num));

int GetSum(int number)
{
    int sum = 0;

    while (number != 0) // пока число не равно нулю
    {
        sum += Math.Abs(number % 10); //используем модуль числа (для случая отрицательного числа на входе)
        number /=10; 
    }
    return sum;
}
