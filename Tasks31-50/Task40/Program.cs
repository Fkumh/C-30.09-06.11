// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

System.Console.Write("Введите первое число: ");
int firstSide = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int secondSide = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int thirdSide = Convert.ToInt32(Console.ReadLine());

bool Triangle(int side1, int side2, int side3)
{
    return (side1 < side2 + side3 && side2 < side1 + side3 && side3 < side1 + side2);
}

bool result = Triangle(firstSide, secondSide, thirdSide);
if (result) System.Console.WriteLine("Треугольник существует!");
else System.Console.WriteLine("ТРЕУГОЛЬНИКА НЕ СУЩЕСТВУЕТ!");