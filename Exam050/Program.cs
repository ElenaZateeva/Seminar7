//Задача 50: На входе принимаем позицию элемента двумерного массива целых чисел
//На экран вывоим массив и заданное значение элемента

Console.WriteLine("Введите строку из массива от 0 до 9");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Введите столбец из массива от 0 до 9");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

if (!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибка ввода данных!");
    return;
}

int[,] array2D = CreateRandom2DArray(10, 10);
Print2DArray(array2D);
PrintArrayElement(array2D,n,m);

int[,] CreateRandom2DArray(int n, int m)
{
    int[,] array = new int[n, m];
    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 100);
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

void PrintArrayElement(int[,] array, int n, int m)
{
    Console.Write($"Элемент массива [{n},{m}]= {array[n, m]} ");
}