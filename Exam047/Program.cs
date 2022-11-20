//Задача 49: Задайте двумерный массив вещественных рандомных чисел
// Вывести на экран. Решать в методах

Console.WriteLine("Введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

double[,] array = CreateRandom2DDoubleArray(m, n);
Print2DArray(array);

double[,] CreateRandom2DDoubleArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (random.Next(-100, 100)) * 0.11;
        }
    }

    return array;
}

void Print2DArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}