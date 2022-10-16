// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeTable(number);

void CubeTable(int num)
{
    int index = 1;
    Console.WriteLine($"Таблица квадратов чисел от 1 до {num}:");
    while (index <= num)
    {
        Console.WriteLine($"|{index, 8}|{Math.Pow(index, 3), 8}|");
        index++;
    }
}