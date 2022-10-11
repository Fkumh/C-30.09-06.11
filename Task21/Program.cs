// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A: ");
Console.Write("X: ");
int dotAX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int dotAY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int dotAZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("X: ");
int dotBX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int dotBY = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int dotBZ = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Distance(dotAX, dotAY, dotAZ, dotBX, dotBY, dotBZ), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {result}");

double Distance (int ax, int ay, int az, int bx, int by, int bz)
{
    // return Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
    double coordX = Math.Pow(ax - bx, 2);
    double coordY = Math.Pow(ay - by, 2);
    double coordZ = Math.Pow(az - bz, 2);
    return Math.Sqrt(coordX + coordY + coordZ);
}
