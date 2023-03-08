// Задача 62: Заполните спирально массив 4 на 4.
// Задается размер массива пользователем.

Console.Clear();
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int number)
{
    int[,] matrix = new int[row, col];
    int count = 0;
    int CountStop = 1;                                  // cчетчик останавливающий заполнение массива. Блягодаря чему можно вывести начало заполнение массива отдельным числом
    while (CountStop <= row * col)
    {
        int i = count;
        int j = count;
        while (j < matrix.GetLength(1) - count)         // заполняем по горизонтали слева направо
        {
            matrix[i, j] = number;
            number++;
            j++;
            CountStop++;
        }
        j = j - 1;
        while (i < matrix.GetLength(0) - 1 - count)     // заполняем в конце сверху вниз
        {
            matrix[i + 1, j] = number;
            number++;
            i++;
            CountStop++;
        }
        while (j < matrix.GetLength(1) && j > count)    // заполняем по горизонтали справа налево
        {
            j = j - 1;
            matrix[i, j] = number;
            number++;
            CountStop++;
        }
        count++;
        while (i < matrix.GetLength(0) && i > count)    // заполняем снизу вверх
        {
            i = i - 1;
            matrix[i, j] = number;
            number++;
            CountStop++;
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

int row = GetNumber("Enter number of rows: ");
int col = GetNumber("Enter number of columns: ");
int num = GetNumber("Enter number from which start filling array: ");
int[,] MyMatrix = GenerateMatrix(row, col, num);
System.Console.WriteLine();
PrintMatrix(MyMatrix);
