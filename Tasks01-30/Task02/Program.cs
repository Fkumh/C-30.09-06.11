Console.Write("Введите число: ");
long L = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите число: ");
long R = Convert.ToInt64(Console.ReadLine());
long count = 0;
long result = 0;
while (L <= R)
{
    if (L > 9) count = count * 100 + L;
    else
    {
        count = count * 10 + L;
    }
    L++;
}

while (count > 0)
{
    count = count / 10;
    result++;
}
Console.WriteLine(result);