Console.WriteLine("Введите целое число m:");
long numb1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите целое число n:");
long numb2 = Convert.ToInt64(Console.ReadLine());

long AkkermanFunc(long num1, long num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    if (num1 > 0 && num2 == 0)
    {
        return AkkermanFunc(num1 - 1, 1);
    }
    return AkkermanFunc(num1 - 1, AkkermanFunc(num1, num2 - 1));
}
Console.WriteLine(AkkermanFunc(numb1, numb2));