// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите 1-ое число: ");
int square = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (square == number * number)
{
    Console.WriteLine($"Первое число ({square}), является квадратом {number}");
}
else
{
    Console.WriteLine($"Первое число ({square}), НЕ является квадратом {number}");
};