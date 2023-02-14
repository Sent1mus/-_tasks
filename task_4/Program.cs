// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());
int numbers = 2;
if (N > 1)
{

    while (numbers <= N)
    {
        System.Console.Write(numbers + " ");
        numbers += 2;
    }
}
else
{
    System.Console.Write("No even numbers from 1 to N");
}