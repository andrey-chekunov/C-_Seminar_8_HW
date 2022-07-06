// Задача 62: Заполните спирально массив 4 на 4.

Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];
int value = 1;
int i = 0;
int j = 0;

while (value <= size * size)
{
    array[i, j] = value;
    if (i <= j + 1 && i + j < size - 1) ++j;
    else if (i < j && i + j >= size - 1) ++i;
    else if (i >= j && i + j > size - 1) --j;
    else --i;
    ++value;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
PrintArray(array);