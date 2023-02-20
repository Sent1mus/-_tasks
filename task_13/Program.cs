Console.Clear();
int GetNumber(string A)                                                 // метод ввода от пользователя
{
    System.Console.WriteLine(A);
    return Convert.ToInt32(Console.ReadLine());
}

int[] fillArray(int A, int B, int C)                                    //метод заполнения массива (размер, левая граница чисел массива, правая граница чисел массива)
{
    int[] arr = new int[A];
    for (int i = 0; i < A; i++)
    {
        arr[i] = new Random().Next(B, C);                               // рандоманая генерация чисел по заданным границам
    }
    return arr;
}


int size = GetNumber("Enter size of array: ");                          // ввод размера массива
if (size > 0)                                                           //проверка на размер массива
{

    int leftBound = GetNumber("Enter left bound random generator: ");
    int rightBound = GetNumber("Enter right bound random generator: ");
    int[] array = fillArray(size, leftBound, rightBound);
    System.Console.WriteLine(string.Join(", ", array));                  //вывод массива так либо отдельным методом
}
else
{
    System.Console.WriteLine("Error in array size");
}