// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int M, int N)
{
    if (M == N)
        return N;
    return M + GetSum(M + 1, N);
}

int M = GetNumber("Enter M: ");
int N = GetNumber("Enter N: ");
int Sum = GetSum(M, N);
System.Console.WriteLine($"Sum of numbers between {M} and {N} = {Sum}");