// Задача 29. 
// Написать  программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

// 1. Метод void

int [] array1 = new int [8];

GetArray1(array1);           
PrintArray1(array1); 

void GetArray1(int [] arr1) 

{
    int length = arr1.Length; // длина массива
    int index = 0; //индекс начинается с 0
   
    while (index < length)
    {

        arr1[index] = new Random().Next(1,50); // обратиться к аргументу arr1 на позицию index и поместить туда новое случайное число из диапазона 1, 50
        index++;

    }
    
}

void PrintArray1(int [] col) // метод печати массива 1
{
    Console.WriteLine($"Массив из 8-ми случайных чисел (void-метод): [{string.Join(" ,", array1)}]");
}

// 2. Return-метод

int [] array2 = GetArray2(8);
    
PrintArray2(array2); 

int [] GetArray2(int size) 
{
    int [] arr2 = new int [size]; 
    
    int i = new Random().Next(1, 50);  
    
    for (i = 0; i < size; i++)  
    {
        arr2 [i] = new Random().Next(1, 50);
        
    }
    
    return arr2;
    
}

void PrintArray2(int [] col) // метод печати массива 2
{
    Console.WriteLine($"Массив из 8-ми случайных чисел (return-метод): [{string.Join(" ,", array2)}]");
}


