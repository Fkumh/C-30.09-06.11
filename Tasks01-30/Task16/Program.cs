// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool result = CheckNumber(firstNumber, secondNumber);

bool CheckNumber (int num1, int num2)
{
    int min = num1;
    int max = num2;
    if (min > max) 
    {
        min = num2;
        max = num1;
    }
    return min * min == max;
}

if (result) Console.WriteLine("Yes");
else Console.WriteLine("No");