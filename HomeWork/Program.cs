
Console.Write("Введите количество строк двумерного массива: ");
int rowCount = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов двумерного массива: ");
int columnCount = int.Parse(Console.ReadLine());

double[,] array = FillArray(rowCount, columnCount);
PrintArray(array);

double[,] FillArray(int rows, int columns)
{
    double[,] filledArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().NextDouble() * 100;
            filledArray[i, j] = Math.Round(filledArray[i, j], 2);
        }
    }
    return filledArray;
}

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"\t{inputArray[i, j]}");
        }
        Console.Write(" ]");
        Console.WriteLine();
    }
}
Console.Write("Введите номер строки массива элемента для вывода: ");
int rowEl = int.Parse(Console.ReadLine());

Console.Write("Введите номер столбца массива элемента для вывода: ");
int columnEl = int.Parse(Console.ReadLine());
Console.WriteLine($"Значение по запросу индекса = {array[rowEl, columnEl]}");

double[,] AverageArray(double[,] arrayEd)
{
    double sumColum = 0;
    double average = 0;

    for (int j = 0; j < arrayEd.GetLength(1); j++)
    {
        for (int i = 0; i < arrayEd.GetLength(0); i++)
        {
            sumColum += arrayEd[i, j];
        }
        average = Math.Round(sumColum / arrayEd.GetLength(0), 2);
        Console.WriteLine($" Среднее арифметическое элементов в {j + 1} столбце = {average}");
        sumColum = 0;
    }
    return arrayEd;
}
AverageArray(array);
