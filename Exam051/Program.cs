//Задача 51: Задайте квадратный двумерный массив 
// Найдите элемент у которых, оба интекса совпадают в массиве и нйдите их сумму.

Console.WriteLine("Введите количество элементов массива n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateRandom2DArray(n,n);
Print2DArray(array);
Console.WriteLine();
SumOfElementsOfMainDiagonal(array);
Console.WriteLine(SumOfElementsOfMainDiagonal(array));


int SumOfElementsOfMainDiagonal(int[,] array)
{ 
    int sum=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (i==j)
            {
                sum+=array[i,j];
            }
        }
    }
    return sum;
}

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1, 10);
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
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}