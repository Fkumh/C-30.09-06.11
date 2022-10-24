// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Введите b1: ");
double perB1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите k1: ");
double perK1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите b2: ");
double perB2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите k2: ");
double perK2 = Convert.ToDouble(Console.ReadLine());

double Meaning1(double b1, double k1, double b2, double k2)
{
    double resY = k1 * (b2 - b1) / (k1 - k2) + b1;
    return resY;
}

double Meaning2(double b1, double k1, double b2, double k2)
{
    double resX = (b2 - b1) / (k1 -k2);
    return resX;
}

double resultY = Meaning1(perB1, perK1, perB2, perK2);
double resultX = Meaning2(perB1, perK1, perB2, perK2);
System.Console.WriteLine($"{resultX} {resultY}");