Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
    while (number > 1000) number = number / 10;
    int result = number % 10;
    Console.WriteLine($"Третья цифра числа {number} --> {result}");
}
else Console.WriteLine("Третьей цифры не существует!");
