// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    int result = DeletNum(number);
    Console.WriteLine($"Из числа {number}, получили число {result}");
}
else Console.WriteLine($"Число {number} не трёхзначное!");
int DeletNum (int num)
{
    int firstNumber = num / 100;
    int secondNumber = num % 10;
    return (number - (firstNumber * 100 + secondNumber)) / 10;
}