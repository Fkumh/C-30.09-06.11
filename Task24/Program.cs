// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = Addition(number);
System.Console.WriteLine($"Сумма чисел от 1 до {number} -> {res}");

int Addition (int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}
