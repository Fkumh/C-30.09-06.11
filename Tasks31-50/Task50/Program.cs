// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет]

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
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j], 4}| ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("|");
    }
}

void SearchArray (int[,] matrix, int[] num)
{
    int one = num[1];
    int two = num[0];
    int result = matrix[one, two];
    Console.WriteLine(result);   
}

int[,] mat = CreateMatrixInt(3, 4, 0, 99);
PrintMatrix(mat);
Console.Write("Введите значения ячейки, через запятую: ");
string str = Console.ReadLine();
int[] strArr = str.Split(",").Select(int.Parse).ToArray();
if (strArr[1] < mat.GetLength(0) && strArr[0] < mat.GetLength(1)) 
{
    SearchArray(mat, strArr);
}
else Console.WriteLine("Ячейки не существует!");


