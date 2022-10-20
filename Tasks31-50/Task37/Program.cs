// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] Multiplicate(int[] arr)
{
    int size = arr.Length;
    if (size % 2 == 1) size = size / 2 + 1;
    else size /= 2;

    int[] newArr = new int[size];
    int maxNumb = arr.Length - 1;

    for (int i = 0; i < size; i++)
    {
            newArr[i] = arr[i] * arr[maxNumb];
            maxNumb--;
    }
    if (arr.Length % 2 == 1) newArr[size - 1] = arr[size - 1];
    return newArr;
}

int[] array = CreateArrayRndInt(11, 0, 5);
PrintArray(array);
int[] result = Multiplicate(array);
System.Console.WriteLine();
PrintArray(result);