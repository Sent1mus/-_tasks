// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindLowestSum(int[,] matrix)
{
    int RowA = 0;
    int LowSum = 0;
    int LowI = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                RowA = RowA + matrix[0, j];
                LowSum = LowSum + matrix[0, j];
            }
            else
            {
                RowA = RowA + matrix[i, j];

            }
        }
        System.Console.WriteLine($"Number sum of row {i} = {RowA}"); //лень считать для проверки
        if (LowSum > RowA)
        {
            LowSum = RowA;
            LowI = i;
        }
        RowA = 0;
    }
    return LowI;
}

int Rows = GetNumber("Enter number of matrix rows:");
int Cols = GetNumber("Enter number of matrix colums:");
System.Console.WriteLine();
int[,] MainMatrix = GenerateMatrix(Rows, Cols);
int LowestI = FindLowestSum(MainMatrix);
PrintMatrix(MainMatrix);
System.Console.WriteLine();
System.Console.WriteLine($"Lowest numbers sum is when row i = {LowestI}");