// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void SearchNumber(int[,] matrix, int coordinateY, int coordinateX)
{
    if (coordinateY < matrix.GetLength(0) && coordinateX < matrix.GetLength(1)) { System.Console.WriteLine($"Searching number is: {matrix[coordinateY, coordinateX]} "); }
    else {System.Console.WriteLine("Wrong coordinates, no such number");}
}

int rows = ReadInt("Enter number of rows: ");
int cols = ReadInt("Enter number of colums: ");
System.Console.WriteLine();
int[,] myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);
System.Console.WriteLine();
int coordinateY = ReadInt("Enter y coordinate: ");
int coordinateX = ReadInt("Enter x coordinate: ");
SearchNumber(myMatrix, coordinateY, coordinateX);
