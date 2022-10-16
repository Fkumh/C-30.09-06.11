// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (number >= count)
{
    Console.WriteLine(Square(count));
    count++;
}

string Square(int num)
{
    return ($"{num} --> {num * num}");
}