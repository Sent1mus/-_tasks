// Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
System.Console.WriteLine("Enter number of the day: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7)
{
    System.Console.WriteLine($"Nonexisting day");
}
else if (day > 0 && day < 6)
{
    System.Console.WriteLine("Work day");
}
else
{
    switch (day)
    {
        case 6:
            System.Console.WriteLine("Saturday - it's a holiday");
            break;
        case 7:
            System.Console.WriteLine("Sunday - it's a holiday");
            break;
    }
}