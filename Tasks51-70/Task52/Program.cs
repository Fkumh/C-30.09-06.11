// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j], 6}| ");
            else Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine("|");
    }
}

void A(int[,] array2D)
{
    Console.WriteLine();
    Console.Write("|");
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        double count = 0;
        double num = 0;
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            count += array2D[i, j];
            num++;
        }
        double res = count / num;
        Console.Write($"{Math.Round(res, 2), 6}| ");

    }
}
int[,] mat = CreateMatrixInt(3, 4, 0, 10);
PrintMatrix(mat);
A(mat);

