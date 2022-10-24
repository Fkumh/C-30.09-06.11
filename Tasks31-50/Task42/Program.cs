// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int number = 13;

int Binary(int num)
{
    int temp = 0;
    int count = 1;
    int i = 10;
    while (num > 1)
    {
        temp = temp + num % 2 * count;
        num = num / 2;
        count = count * i;
    }
    return temp;
}

int result = Binary(number);
Console.WriteLine($"{number} --> {result}");