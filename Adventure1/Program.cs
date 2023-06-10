// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2




void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        do
        {
            array[i] = new Random().Next(-999, 1000);
        }
        while (array[i] < 99 && array[i] > -99);
    }
    System.Console.WriteLine("Массив:  ");
}
int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] % 2 == 0)
        {
            count++;
        }

    }
    return count;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Enter length array:   ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];


FillArray(Array);
EvenNumbers(Array);
PrintArray(Array);

System.Console.WriteLine($"Количество чётных чисел в массиве имеет значение:  {EvenNumbers(Array)}");