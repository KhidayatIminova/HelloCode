Console.Clear();
// void-метод - метод, который ничего не возвращает, оператор return не нужен 
void FillArray(int [] collection) // collection - имя аргумента, FillArray - имя метода
{
    int length = collection.Length; // длина массива
    int index = 0; //индекс начинается с 0
   
    while (index < length)
    {

        collection[index] = new Random().Next(1,10); // обращтиться к аргументу coolection на позицию index и положить туда новое случайное число из диапазона 1, 10
        index++;

    }
}

void PrintArray(int [] col) // метод печати массива
{
    int count = col.Length;
    int position = 0; //индекс начинается с 0

    while (position < count)
    {
        Console.Write(col[position] + " "); 
        position++;
    
    }
}


int IndexOf(int [] collection, int find) // метод, отличный от void
{
    int count = collection.Length;
    int index = 0;
    //int position = 0;
    int position = -1; // решение для случая, когда искомого элемента в массиве нет (если укажем 0, то и в случае отсутствия покажет 0) 
     while (index < count)
     {
        if(collection[index] == find) // == эквивалентно "равенство": "если значение элемента масива равно find"
        {
            position = index;
            break;
        }
        index++;
      }
     return position;
}
int [] array = new int [10]; // в массиве будет 10 элементов. new int - "создать новый массив, в котором будет 10 элементов". По умолчанию он будет наполнен нулями.

FillArray(array); //вызываем метод заполнения массива
PrintArray(array); // вызываем метод вывода массива на экран
Console.WriteLine();

int pos = IndexOf(array, 4); // ищем четверку
Console.WriteLine(pos);