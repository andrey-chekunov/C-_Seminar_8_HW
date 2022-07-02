// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 

int[,] array = new int[2, 3];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) array[i, j] = new Random().Next(10);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
int minSumRow = int.MaxValue, indexMinRow = 0;
void SumRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            indexMinRow = i;
        }
    }
    Console.Write("The row with the smallest sum of elements is: ");
    for (int j = 0; j < array.GetLength(1); j++) Console.Write(array[indexMinRow, j] + " ");
}
FillArray(array);
PrintArray(array);
SumRow(array);