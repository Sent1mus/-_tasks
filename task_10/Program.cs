// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
System.Console.WriteLine("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int index = 0; index <= N; index++)
{
    System.Console.Write(Math.Pow(index, 3) + ", ");
}