//Console.WriteLine("Введите количество строк массива: ");
//int rows = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите количество столбцов массива: ");
//int columns = int.Parse(Console.ReadLine());
int m = 4;
int n = 4;

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);

Console.WriteLine("Введите номер строки для поиска числа: ");
int t0 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца для поиска числа: ");
int t1 = int.Parse(Console.ReadLine());


void Poisk(int[,] tArray, int t0Loc, int t1Loc)
{
    if ( t0Loc < 0 || t0Loc > tArray.GetLength(0) - 1 || t1Loc < 0 || t1Loc > tArray.GetLength(1) - 1)
    {
        Console.WriteLine("не существует такого элемента!"); 
    }
    else
     {
        Console.WriteLine($" {tArray[t0Loc, t1Loc]}");
     }
}

Poisk(array, t0, t1);

