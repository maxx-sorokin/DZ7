// Задача 50. Напишите программу, которая на вход принимает позиции
// элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

Console.Write("Введите количество строк m: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов n: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);

Console.Write("Введите номер строки элемента: ");
bool isParsedRow = int.TryParse(Console.ReadLine(), out int row);
Console.Write("Введите номер столбца элемента: ");
bool isParsedColumn = int.TryParse(Console.ReadLine(), out int column);

if (!isParsedRow || !isParsedColumn)
{
    Console.WriteLine("Ошибка!");
    return;
}

if (row > 0 && row < array.GetLength(0) - 1 && 
    column > 0 && column < array.GetLength(1) - 1)
{
    Console.WriteLine(array[row - 1, column - 1]);
}
else
{
    Console.WriteLine("Такого элемента нет");
}

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}