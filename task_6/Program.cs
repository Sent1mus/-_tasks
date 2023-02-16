// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.Clear();
System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 1000)
{
    number = number / 10;
}
if (number < 100)
{
    System.Console.WriteLine("No third digit");
}
else
{
    System.Console.WriteLine($"Third digit is {number % 10}");
}