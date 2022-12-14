// Генерирующий метод заполнения массива случайными величинами

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    // Данная строчка выделит память под массив array с кол-вом эл-ов size
     int[] array = new int[size];
     
     for(int i = 0; i < size; i++)
        // Включение верхнего предела массива прибавлением +1 к индексу
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

// Вывод массива в терминал
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1} element is {array[i]}");
    }
}

Console.Write("Imput number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

// Вызываем метод, возвращаем массив
int[] myArray = CreateRandomArray(length, min, max);
WriteArray(myArray);




