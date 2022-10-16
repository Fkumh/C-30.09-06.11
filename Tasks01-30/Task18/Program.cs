// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string result = Quarter(num);

Console.WriteLine(result);

string Quarter(int quarterc)
{
    if (quarterc == 1) return "x > 0 и y > 0";
    if (quarterc == 2) return "x < 0 и y > 0";
    if (quarterc == 3) return "x < 0 и y < 0";
    if (quarterc == 4) return "x > 0 и y < 0";
    return "Неверная четверть";
}
