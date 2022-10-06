Console.Clear();

/* Console.Write("Введите размер массива для разворота:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array, 0, 99);
PrintArray(array);
ReversMassive(array);
PrintArray(array); */

void FillArray(int[] value, int min = 0, int max = 10)
{
    for (int i = 0; i < value.Length; i++)
    {
        value[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] value)
{
    Console.Write("[");
    for (int i = 0; i < value.Length; i++)
    {
        Console.Write(" " + value[i] + " ");
    }
    Console.WriteLine("]");
}

void ReversMassive(int[] value)
{
    int size = value.Length - 1;
    for (int i = 0; i < value.Length / 2; i++)
    {
        (value[i], value[size - i]) = (value[size - i], value[i]);
    }
}
 
