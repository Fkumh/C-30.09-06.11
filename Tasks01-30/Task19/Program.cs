// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100000)
{
    bool result = CheckNumber(number);
    if (result == true) Console.WriteLine($"{number} --> Да");
    else Console.WriteLine($"{number} --> Нет");
}
else System.Console.WriteLine("Неверное число!");

bool CheckNumber(int num)
{
    int FirstNumber = num / 10000;
    int FifthNumber = num % 10;
    if (FirstNumber == FifthNumber)
    {
        int secondNumber = num / 1000 - FirstNumber * 10;
        int FourthNumber = num % 100 - FifthNumber;
        return true;
    }
    else return false;
}