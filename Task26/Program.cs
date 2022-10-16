// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int res = Amount(number);
System.Console.WriteLine(res);

int Amount (int num)
{
    int count = default;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}