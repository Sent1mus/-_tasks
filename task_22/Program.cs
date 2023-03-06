// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortMatrix(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int Rows = GetNumber("Enter number of matrix rows:");
int Cols = GetNumber("Enter number of matrix colums:");
System.Console.WriteLine();
int[,] MainMatrix = GenerateMatrix(Rows, Cols);
// int[,] MainMatrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int[,] NewMatrix = SortMatrix(MainMatrix);
PrintMatrix(MainMatrix);
System.Console.WriteLine();
PrintMatrix(NewMatrix);