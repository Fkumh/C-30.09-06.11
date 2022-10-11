// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A: ");
Console.Write("X: ");
int dotAX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int dotAY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int dotBX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int dotBY = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Distance(dotAX, dotAY, dotBX, dotBY), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {result}");

double Distance (int ax, int ay, int bx, int by)
{
    return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
}