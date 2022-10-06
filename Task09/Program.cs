// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10,100);
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit == secondDigit) Console.WriteLine($"Числа одинаковые! {number}");
// else 
// {
// int res = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа {number}: {res}");
// }

int maxDigit = MaxDigit(number);

int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;

    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
Console.WriteLine($"Наибольшая цифра числа {number}: {maxDigit}");