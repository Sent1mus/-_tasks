// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Enter 2 numbers: ");
int a = Convert.ToInt32(System.Console.ReadLine());
int b = Convert.ToInt32(System.Console.ReadLine());
int max = 0;
if (a > b)
{
    max = a;
    System.Console.WriteLine($"Максимальное число {max}");
}
else if (b>a)
{
    max = b;
    System.Console.WriteLine($"Максимальное число {max}");
}
else
{
    max=a;
    System.Console.WriteLine($"Числа равны");
}
