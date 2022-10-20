// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

int[] CreateArrayRndInt(int size, int min, int max)
{
    var array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) System.Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int Count (int[] array)
{
    int res = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] <100) res++;
    }
    return res;
}

int[] arr = CreateArrayRndInt(123, 0, 200);
PrintArray(arr);
int result = Count(arr);
Console.WriteLine($"--> {result}");
