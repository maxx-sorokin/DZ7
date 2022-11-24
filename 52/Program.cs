// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Поиск среднее арифметического в отдельном методе.
// Для создания массива и вывода можно воспользоваться методами из 47 задачи.

Console.Write("Введите количество строк m: ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов n: ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

double[,] array = CreateRandom2DArray(m, n);
Print2DArray(array);

Console.WriteLine();

double[] newArray = ArithmeticMeanInColumns(array);
PrintArray(newArray);

double[] ArithmeticMeanInColumns(double[,] array)
{
    double[] arithmeticMean = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            arithmeticMean[j] += array[i, j];
        }
        arithmeticMean[j] /= array.GetLength(0);
    }
    return arithmeticMean;
}

double[,] CreateRandom2DArray(int m, int n)
{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 100) + Math.Round(random.NextDouble(), 2);
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}