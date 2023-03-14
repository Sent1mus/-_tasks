// // Задача 68: Напишите программу вычисления функции Аккермана с помощью
// // рекурсии. Даны два неотрицательных числа m и n.
// // m = 2, n = 3 -> A(m,n) = 29


Console.Clear();
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Function(int M, int N)
{
    if (M == 0)
        return N + 1;
    else if (N == 0)
        return Function(M - 1, 1);
    else
        return Function(M - 1, Function(M, N - 1));
}

start:
int M = GetNumber("Enter M: ");
int N = GetNumber("Enter N: ");
if (M < 0 || N < 0)
{
    System.Console.WriteLine("Enter numbers with positive value");
    goto start;
}
int F = Function(M, N);
System.Console.WriteLine($"{F}");
