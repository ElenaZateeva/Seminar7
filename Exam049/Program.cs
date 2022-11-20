//Задача 49: Задайте двумерный массив 
// Найдите элемент у которых, оба интекса нечетные и возвести в квадрат.

Console.WriteLine("Введите m - ");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите n - ");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateRandom2DArray(m,n);
Print2DArray(array);
Console.WriteLine();
SquaredElementsWithOddIndexes(array);
Print2DArray(array);


void SquaredElementsWithOddIndexes(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(0); j++)
        {
            if (i%2!=0 & j%2!=0)
            {
                array[i,j]=array[i,j]*array[i,j];
            }
        }
    }
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
