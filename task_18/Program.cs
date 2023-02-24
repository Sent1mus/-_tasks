// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =
// 9 -> (-0,5; -0,5)

Console.Clear();
double Input(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[] Calc(double k1, double b1, double k2, double b2)                         // вычисление точки 
{
    double[] array = new double[2];
    if (k1 == k2)
        System.Console.WriteLine("Lines are parallel");
    else
    {
        array[0] = (b2 - b1) / (k1 - k2);                                         // x coordinate
        array[1] = k1 * array[0] + b1;                                            // y coordinate
    }
    return array;
}

double k1 = Input("Enter k1 coefficient: ");
double b1 = Input("Enter b1 coefficient: ");
double k2 = Input("Enter k2 coefficient: ");
double b2 = Input("Enter b2 coefficient: ");
double[] array = Calc(k1, b1, k2, b2);
System.Console.WriteLine($"Coordinates are: [" + string.Join(",", array) + "]");