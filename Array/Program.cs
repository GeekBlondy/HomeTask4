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
        // В терминале нулевой индекс элемента выводим как первый для удобства восприятия
        Console.WriteLine($"{i + 1} element is {array[i]}");
        // Либо вывод элементов в строку
        // Console.Write(array[i] + " ");
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



// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Math.Pow не использовать, изобрести метод аналогичный. Проверка Math.Pow

// 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Как факториал

// 3. Напишите программу, которая задаёт массив из size элементов и выводит их на экран.
// Написать метод числами по запросу пользователя writeline, readline