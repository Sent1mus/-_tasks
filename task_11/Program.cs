// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int Number(string N)
{
    System.Console.WriteLine(N);
    return Convert.ToInt32(Console.ReadLine());
}

int A = Number("Enter number A: ");
int B = Number("Enter number B: ");
int result = 1;
for (int i = 1; i <= B; i++)
{
    result = result * A;
}
System.Console.WriteLine(result);