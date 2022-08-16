// Задача 18. Написать программу, которая по заданному номеру четверти показывает диапазон возможных координат x и y

Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());

switch(num)
{
    case 1:
        Console.WriteLine("x>0 && y>0");
        break;
    case 2:
    Console.WriteLine("x<0 && y>0");
    break;
    // default:
    
    // Console.WriteLine("все остальные случаи");
    
    
}