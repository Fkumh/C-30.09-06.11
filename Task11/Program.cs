// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72

int number = new Random().Next(100,1000);
int result = DeletNum(number);
int DeletNum (int num)
{
    int firstNumber = num / 100;
    int secondNumber = num % 10;
    return firstNumber * 10 + secondNumber;
}
Console.WriteLine($"Из числа {number}, получили число {result}");