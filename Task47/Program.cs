// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


//Создаем функцию инициализирующую массив(пустой)
//Создаем функцию,которая заполняет этот массив
//Создаем функцию,которая печатает этот массив
//строки 0,столбцы1

double[,] CreateArray(int m, int n)
{
    double[,] array = new double[m, n];
    return array;
}

double[,] FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int q = 0; q < array.GetLength(1); q++)
        {
            array[i, q] = Convert.ToDouble(new Random().Next(-10, 10) / 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int q = 0; q < array.GetLength(1); q++)
        {
            Console.Write($"{array[i, q]}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите длинну массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите ширину массива");
int n = int.Parse(Console.ReadLine());

PrintArray(FillArray(CreateArray(m, n)));