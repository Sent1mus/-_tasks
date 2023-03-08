// Задача 60: Сформируйте трёхмерный массив из двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя
// индексы каждого элемента.

Console.Clear();
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GenerateMatrix(int row, int col, int arr)
{
    int[,,] matrix = new int[row, col, arr];
    for (int k = 0; k < arr; k++)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j, k]}({i},{j},{k}) \t");
            }
            System.Console.WriteLine();
        }
    }
}

int row = GetNumber("Enter number of rows: ");
int col = GetNumber("Enter number of columns: ");
int arr = GetNumber("Enter number of arrays: ");
int[,,] MyMatrix = GenerateMatrix(row, col, arr);
System.Console.WriteLine();
PrintMatrix(MyMatrix);
