// Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
int Coordinates(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = Coordinates("Enter x1: ");
int y1 = Coordinates("Enter y1: ");
int z1 = Coordinates("Enter z1: ");
int x2 = Coordinates("Enter x2: ");
int y2 = Coordinates("Enter y2: ");
int z2 = Coordinates("Enter z2: ");
System.Console.WriteLine($"Distance between dots = {Math.Round(Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)) + (Math.Pow((z2 - z1), 2))), 2)}");