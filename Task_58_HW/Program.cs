// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Произведением двух матриц будет матрица, элементы которой равны сумме попарных произведений элементов 
// строки первой матрицы на соответствующие элементы столбца второй матрицы: 
// Из этого следует что перемножить между собой можно матрицы в которых количество столбцов первой равно количеству строк второй.

Console.WriteLine("Specify a matrix of size m*n: ");
Console.Write("Enter m (rows) for first matrix: ");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n (columns) for first matrix: ");
int columnsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter m (rows) for second matrix: ");
int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter n (columns) for second matrix: ");
int columnsSecondMatrix = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = new int[rowsFirstMatrix, columnsFirstMatrix];
int[,] secondMatrix = new int[rowsSecondMatrix, columnsSecondMatrix];
int[,] resultMatrix = new int[rowsFirstMatrix, columnsSecondMatrix];

void MultiplicationMatrixes(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int multiplication = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++) multiplication += firstMatrix[i, k] * secondMatrix[k, j];
            resultMatrix[i, j] = multiplication;
        }
    }
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)  array[i, j] = new Random().Next(10);
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
FillArray(firstMatrix);
FillArray(secondMatrix);
PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);
MultiplicationMatrixes(firstMatrix, secondMatrix, resultMatrix);
Console.Write("The result of multiplying two matrices is: ");
PrintArray(resultMatrix);