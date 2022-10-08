// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

int result = Multiple(firstNumber);

int Multiple (int num)
{
    int multipleOne = firstNumber % 7;
    int multipleTwo = firstNumber % 23;
    int res = default;
    if (multipleOne == 0 && multipleTwo == 0) res = 1;
    else res = 0;
    return res;
}

if (result == 1) Console.WriteLine($"Число {firstNumber} кратно");
else Console.WriteLine($"Число {firstNumber} не кратно");