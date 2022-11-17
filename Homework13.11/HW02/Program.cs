Console.WriteLine("Введите целое число:");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число:");
int numb2 = Convert.ToInt32(Console.ReadLine());
int result = default;

void NaturalNumbers(int num1, int num2, int res)
{
    if (num1 == num2)
    {
        res += num1;
    }
    if (num1 < num2)
    {
        res += num1;
        NaturalNumbers(num1 + 1, num2, res);
    }
    else Console.WriteLine(res);
}
if (numb1 > numb2) NaturalNumbers(numb2, numb1, result);
else NaturalNumbers(numb1, numb2, result);

