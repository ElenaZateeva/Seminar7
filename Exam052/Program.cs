//Задача 52: Задайте двумерный массив целых рандомных чисел
//Найти среднее арифметическое столбцов и вывести в новый 1й массив.

Console.WriteLine("Введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array2D = CreateRandom2DArray(m, n);
Print2DArray(array2D);
double[] array1D = AverageArrayColumn(array2D);
Print1DArray(array1D);

double[] AverageArrayColumn(int[,] array2)
{
    double[] array1 = new double[array2.GetLength(1)];
    for (var i = 0; i < array2.GetLength(1); i++)
    {
        int sum = 0;
        double average=0.00;
        for (var j = 0; j < array2.GetLength(0); j++)
        {
            sum += array2[j, i];
        }
        average=sum *100/ array2.GetLength(0);
        array1[i] = average*0.01;
    }
    return array1;
}

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
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
void Print1DArray(double[] array)
{
    Console.WriteLine();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
}
