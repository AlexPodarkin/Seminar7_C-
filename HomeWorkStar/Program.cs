Console.Clear();
/* Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача (задача со звёздочкой): Задайте двумерный массив 
из целых чисел. Определите, есть столбец в массиве, сумма которого,
 больше суммы элементов расположенных в четырех "углах" двумерного массива.
Например, задан массив:
4 4 7 5
4 3 5 3
8 1 6 8 -> нет */
Console.Write("Введите кол-во строк созд. массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов созд. массива:");
int table = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, table, 0, 10);
PrintArray(array);
Console.WriteLine("---------------------------");
int sum4angle = summ4angle(array);
Console.WriteLine($"Сумма угловых значений массива = {sum4angle}");
Console.WriteLine("---------------------------");
ComparisonColumnsAndAngularValues();

int[,] FillArray(int row, int table, int min = 1, int max = 10)
{
    Random random = new Random();
    int[,] array = new int[row, table];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write("  " + massiv[i, j] + " ");
        }
        Console.WriteLine("]");
    }
}

int summ4angle(int[,] massiv)
{
    int lenRow = massiv.GetLength(0) - 1;
    int lenTable = massiv.GetLength(1) - 1;
    int summ4angle = 0;
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if (i == 0 && j == 0 || i == 0 && j == lenTable || j == 0 && i == lenRow || i == lenRow && j == lenTable)
            {
                summ4angle += massiv[i, j];
            }

        }
    }
    return summ4angle;
}

void ComparisonColumnsAndAngularValues()
{
int summTable = 0;
for (int j = 0; j < array.GetLength(1); j++)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        summTable += array[i, j];
    }
    if (summTable > sum4angle)
    { Console.WriteLine($"Сумма {j + 1} столбца = {summTable} !!! ЭТО БОЛЬШЕ суммы уговых значений массива!"); }
    else
    { Console.WriteLine($"Сумма {j + 1} столбца = {summTable} что не больше суммы уговых значений массива!"); }
    summTable = 0;
}
}

//когда сделал задачу подумал что найти 
//сумму угловых значений можно гораздо прощще
Console.WriteLine("---------------------------");
int summAngularValues = array[0, 0]  
             + array[0, array.GetLength(1) - 1] 
             + array[array.GetLength(0) - 1, 0] 
             + array[array.GetLength(0)-1,array.GetLength(1)-1];
Console.WriteLine($"более простой способ нахождения угловых значений = "+ summAngularValues);