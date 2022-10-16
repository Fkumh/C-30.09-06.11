// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Multiplication(number1, number2);
System.Console.WriteLine($"Число {number1} в степени {number2} --> {result}");

int Multiplication (int num1, int num2)
{
    int res = 1;
    for (int i = 1; i <= num2; i++)
    {
        res = res * num1;
    }
    return res;
}
