
Console.Clear();

Console.Write("Введите количество строк двумерного массива: ");
int rowCount = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов двумерного массива: ");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1, 9);
PrintArray(array);

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = i + j;
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}

FillArra(array);
int[,] FillArra(int[,] filladArra)
{

    for (int i = 0; i < filladArra.GetLength(0); i++)
    {
        for (int j = 0; j < filladArra.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                filladArra[i, j] = filladArra[i, j] * filladArra[i, j];
            }
        }
    }
    return filladArra;
}
Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();

int[,] SumDia(int[,] filladArra)
{
    int summ = 0;

    for (int i = 0; i < filladArra.GetLength(0); i++)
    {
        for (int j = 0; j < filladArra.GetLength(1); j++)
        {
            if (i == j)
            {
                summ += filladArra[i, j];
            }
        }
    }
    System.Console.WriteLine(summ);
    return filladArra;
}
SumDia(array);