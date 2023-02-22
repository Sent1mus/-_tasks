// // Задача 38: Задайте массив вещественных чисел. Найдите
// // разницу между максимальным и минимальным
// // элементов массива.
// // [3 7 22 2 78] -> 76

Console.Clear();

int Promt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[] GenerateArray(int Lenght)
{
    double[] array = new double[Lenght];
    for (int i = 0; i < Lenght; i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*20, 2);
    }
    return array;
}
double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else
        {
            if (min > array[i])
                min = array[i];

        }
    }
    return max - min;

}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int lenght = Promt("Enter array lenght: ");
double[] Array = GenerateArray(lenght);
PrintArray(Array);
double minMax = Difference(Array);
System.Console.WriteLine($"Differencebetween max and min numbers is: {minMax}");