// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число (число не должно быть отрицательным): ");
int num = Convert.ToInt32(Console.ReadLine());
int counted = 1;

if (num >= 0)
{
    while (counted <= num)
    {
        if (counted % 2 == 0) Console.Write($"{counted} ");
        counted++;
    };
}
else Console.WriteLine("Число отрицательное!");