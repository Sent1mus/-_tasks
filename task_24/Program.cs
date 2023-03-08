// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

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

int[,] FindAverage(int[,] FirstMatrix, int[,] SecondMatrix)
{
    int[,] MatrixMultiply = new int[FirstMatrix.GetLength(0), SecondMatrix.GetLength(1)];
    int Sum = 0;
    if (FirstMatrix.GetLength(0) == SecondMatrix.GetLength(1))
    {
        for (int i = 0; i < FirstMatrix.GetLength(0); i++)
        {
            for (int k = 0; k < MatrixMultiply.GetLongLength(1); k++)
            {
                for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                {
                    Sum = FirstMatrix[i, j] * SecondMatrix[j, k] + Sum;
                }
                MatrixMultiply[i, k] = Sum;
                Sum = 0;
            }
        }
    }
    return MatrixMultiply;
}


int Rows1 = GetNumber("Enter number of 1st matrix rows:");
int Cols1 = GetNumber("Enter number of 1st matrix colums:");
int Rows2 = GetNumber("Enter number of 2nd matrix rows:");
int Cols2 = GetNumber("Enter number of 2nd matrix colums:");
System.Console.WriteLine();
int[,] FirstMatrix = GenerateMatrix(Rows1, Cols1);
System.Console.WriteLine("First Matrix is:");
PrintMatrix(FirstMatrix);
System.Console.WriteLine();
int[,] SecondMatrix = GenerateMatrix(Rows2, Cols2);
System.Console.WriteLine("Second Matrix is:");
PrintMatrix(SecondMatrix);
System.Console.WriteLine();
int[,] MatrixMultiply = FindAverage(FirstMatrix, SecondMatrix);
if (Rows1 == Cols2)
{
    PrintMatrix(MatrixMultiply);
}
else
{
    System.Console.WriteLine($"Cant myltiply");
}



