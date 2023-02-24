// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
int[] InputArray(string message)
{
    System.Console.WriteLine(message);
    var array = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
    return array;
}

void CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Positive numbers: {count}");
}

int[] MyArray = InputArray("Enter array: ");
CountPositive(MyArray);