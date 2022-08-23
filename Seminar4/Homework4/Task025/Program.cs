Console.Clear();
// Задача 25. Написать  цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

GetPow1(a, b);
GetPow2(a, b);

// 1. Метод с использованием цикла

double GetPow1(double bas, double ex) // Метод, который возвращает перемножение (деление) числа самого на себя (b) раз 
{
    double result = 1;

    if (ex != 0)

    {
        for (int i = 1; i <= Math.Abs(ex); i++)
        {
            if (ex > 0)
            {
                result = result * bas; // целая положительная степень (натуральная)
            }
            else 
            {
                result = result / bas; // целая отрицательная степень
            }
        }
    }

    else result = 1; // нулевая степень
    
    Console.WriteLine($"\nМетод возведения целого числа в натуральную степень с использованием цикла: \n({a})^({b}) = {result} ");

    return result;

}

// 2. Метод без использования цикла

void GetPow2(double bas, double ex)
{
    double result2 = Convert.ToDouble(Math.Pow(bas, ex));
    Console.WriteLine($"\nМетод возведения числа в степень через Math.Pow: \n({bas})^({ex}) = {result2} ");
}

