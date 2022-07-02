// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = { { 5, 8, 4, 7, 9, 2, 1 }, { 12, 18, 66, 35, 48, 69, 88 } };
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k ] = array[i, k+1];
                    array[i, k+1] = temp;
                }
            }
        }
    }
}
Console.WriteLine("Source array:");
PrintArray(array);
SortArray(array);
Console.WriteLine("Sotred array:");
PrintArray(array);

