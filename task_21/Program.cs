// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random random = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 21);
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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void ColumsAverage(int[,] matrix)
{
    double sum=0;
    int count=0;
    double result=0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum+=matrix[i,j];
            count++;
        }
           System.Console.WriteLine($"Average sum of colum №{j} = {Math.Round((result=sum/count),2)}");
           sum=0;
           count=0;
}
}

int rows = ReadInt("Enter number of rows: ");
int cols = ReadInt("Enter number of colums: ");
System.Console.WriteLine();
int[,] myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
ColumsAverage(myMatrix);