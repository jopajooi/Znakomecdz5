
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
System.Console.WriteLine("Enter length array:   ");
int size = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[size];


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = new Random().Next();
    }
    System.Console.WriteLine("Массив:  ");
}
int NoEvenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < size; i += 2)
    {

        sum += array[i];
    }

    return sum;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}


FillArray(Array);
NoEvenNumbers(Array);
PrintArray(Array);

System.Console.WriteLine($"Сумма нечётных чисел в массиве имеет значение:  {NoEvenNumbers(Array)}");