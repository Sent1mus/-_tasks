// Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.

Console.Clear();
System.Console.WriteLine("Enter 5 digit number: ");
string number = Console.ReadLine();
int length = number.Length;
if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine("Number is palindrom");
    }
    else
    {
        System.Console.WriteLine("Number is NOT palindrom");
    }
}
else
{
    System.Console.WriteLine("Number is not 5 digit");
}