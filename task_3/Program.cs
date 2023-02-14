// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N == 0)
{
    System.Console.WriteLine("You entered ZERO"); //check if 0
}
else if (N % 2 == 0)
{
    System.Console.WriteLine("Even number"); //четное число
}
else
{
    System.Console.WriteLine("Odd number"); // нечетное число
}