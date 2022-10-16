Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number < 6) Console.WriteLine("Не выходной");
    else Console.WriteLine("Выходной");
}
else Console.WriteLine("Введенно неверное значение!");