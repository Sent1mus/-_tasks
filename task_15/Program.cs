// // Задача 36: Задайте одномерный массив, заполненный
// // случайными числами. Найдите сумму элементов, стоящих
// // на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

Console.Clear();

int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int Lenght, int minValue, int maxValue)
{
    int[] array = new int[Lenght];
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

int SumIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i +=2)
    {
        sum+= array[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
     System.Console.WriteLine("[" + string.Join(", ", array )+ "]");
}

int lenght = Promt("Enter array lenght: ");
int minValue = -9;
int maxValue = 9;
int[] Array = GenerateArray(lenght, minValue, maxValue);
PrintArray(Array);
System.Console.WriteLine($"Sum of odd numbers is: {SumIndex(Array)}");

