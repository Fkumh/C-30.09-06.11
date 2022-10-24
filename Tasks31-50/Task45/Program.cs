// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] CopyArray(int[] array)
{
    int[] newArr = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArr[i] = array[i];
    }
    return newArr;
}
int[] arr = CreateArrayRndInt(5, 0, 10);
PrintArray(arr);
int[] result = CopyArray(arr);
System.Console.Write(" --> ");
PrintArray(result);
