// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

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

int[] GetSumPositiveNegativElem (int[] array)
{
    int sumNegative = default;
    int sumPositive = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive += array[i];
        else sumNegative += array[i];
    }
        return  new int[] {sumPositive, sumNegative}; 
}
int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int[] result = GetSumPositiveNegativElem(arr);

System.Console.WriteLine();
Console.WriteLine($"Сумма положительных: {result[0]}");
Console.WriteLine($"Сумма отрицательных: {result[1]}");


