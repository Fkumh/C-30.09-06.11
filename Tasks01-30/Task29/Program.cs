// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int [8];

FillNumber(array);
PrintArray(array);

void FillNumber (int[] num)
{
    Random rnd = new Random();
    for (int i = 0; i < num.Length - 1; i++)
    {
        num[i] = rnd.Next(0,50);
        Console.Write($"{num[i]}, ");
    }
    System.Console.Write($"{num[7]} --> ");
}

void PrintArray (int[] num)
{
    System.Console.Write("[");
    for (int i = 0; i < num.Length - 1; i++)
    {
        Console.Write($"{num[i]}, ");
    }
    System.Console.WriteLine($"{num[7]}]");
}