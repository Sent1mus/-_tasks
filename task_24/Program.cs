// Задача 52: Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.


Console.Clear();
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int Rows, int Cols)
{
    int[,] matrix = new int[Rows, Cols];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Cols; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

void FindAverage(int[,] matrix)
{
    double RowAverage = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            RowAverage = RowAverage + matrix[i, j];
        }
        System.Console.WriteLine($"Average of row {i} = {RowAverage / matrix.GetLength(1)}");
        RowAverage = 0;
    }
}

int Rows = GetNumber("Enter number of matrix rows:");
int Cols = GetNumber("Enter number of matrix colums:");
System.Console.WriteLine();
int[,] MainMatrix = GenerateMatrix(Rows, Cols);
PrintMatrix(MainMatrix);
System.Console.WriteLine();
FindAverage(MainMatrix);