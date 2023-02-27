// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int InputNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(System.Console.ReadLine());
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}" + "\t");
        }
        System.Console.WriteLine();
    }
}
double[,] GenerateMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double random = Math.Round(new Random().Next(0, 10) + new Random().NextDouble(), 2);
            matrix[i,j] = random;
        }

    }
    return matrix;
}
int rows = InputNumber("Enter number of rows: ");
int cols= InputNumber("Enter number of colums: ");
double[,] matrix = GenerateMatrix(rows, cols);
PrintMatrix(matrix);