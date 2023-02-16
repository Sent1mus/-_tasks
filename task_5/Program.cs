// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого
// числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
System.Console.WriteLine("Enter three-digit number: ");
int number = int.Parse(Console.ReadLine());
int result = 0;
if (Math.Abs(number) > 99 && Math.Abs(number) < 1000)
{
    result = Math.Abs((number / 10) % 10);
    System.Console.WriteLine($"second digit is: {result}");
}
else
{
    System.Console.WriteLine("Number is not three-digit");
}