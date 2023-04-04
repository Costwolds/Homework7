// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

//Создаем функцию,которая создаст массив
//Создаем функцию,которая заполнит массив
//Создаем функцию,которая выведет этот массив на экран
//Создаем функцию,которая будет искать элемент внутри этого массива

int[,] Array(int m, int n)
{
    int[,] array = new int[m, n];

    return array;
}

int[,] NewArray(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int q = 0; q < array.GetLength(1); q++)
        {
            array[i, q] = new Random().Next(-10, 10);
        }

    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int q = 0; q < array.GetLength(1); q++)
        {
            Console.Write($"{array[i, q]} ");
        }
        Console.WriteLine();
    }
}

void FindElement(int[,] array, int number1, int number2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int q = 0; q < array.GetLength(1); q++)
        {
            if (i == number1 && q == number2)
            {
                Console.WriteLine($"искомый элемент равен {array[i, q]}");
            }
            


        }

    }
    if (number1>=array.GetLength(0) && number2>= array.GetLength(1))
            {
                Console.WriteLine("Такого элемента нет,введите меньшее значение");
            }
   
    }
    
Console.WriteLine("Введите длинну массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите ширину массива");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер строки");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] ResultArray = NewArray(Array(m, n));
PrintArray(ResultArray);
FindElement(ResultArray, number1, number2);