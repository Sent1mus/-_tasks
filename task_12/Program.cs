// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
System.Console.WriteLine("Enter number: ");
string? number = Console.ReadLine();
int result = 0;
if (number[0] != '-')                                           // я хз, но как-то я пришел к такому костылю на проверку отриц числа,
{                                                               // тк иначе просто не хотел считать отриц число
    for (int i = 0; i < number.Length; i++)
    {
        int temp = Convert.ToInt32(Convert.ToString(number[i]));
        result = result + temp;
    }
}
else
    for (int i = 1; i < number.Length; i++)
    {
        int temp = Convert.ToInt32(Convert.ToString(number[i]));
        result = result + temp;
    }
System.Console.WriteLine(result);