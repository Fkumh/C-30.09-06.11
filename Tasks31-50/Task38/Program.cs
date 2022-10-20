// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRndDouble(int size, int min, int max)
{
    var array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double rndNum = array[i] = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndNum, 2);
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double SearchNum (double[] arr)
{
    double SearchMaxNum = arr[0];
    double SearchMinNum = arr[0];
    double res = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > SearchMaxNum) SearchMaxNum = arr[i];
        if (arr[i] < SearchMinNum) SearchMinNum = arr[i];
    }
    return (SearchMaxNum - SearchMinNum);
}

double[] array = CreateArrayRndDouble(6, 3, 10);
PrintArrayDouble(array);
double result = SearchNum(array);
System.Console.WriteLine($" --> {result}");
