// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// 
 
int rows1 = 2;
int columns1 = 2;
int rows2 = 2;
int columns2 = 2;

int[,] matrix1 = GenerateRandomMatrix(rows1, columns1);
int[,] matrix2 = GenerateRandomMatrix(rows2, columns2);


if (columns1 != rows2)
{
    Console.WriteLine("Невозможно выполнить умножение матриц");
    return;
}

int[,] result = MultiplyMatrix(matrix1, matrix2);

Console.WriteLine("Результирующая матрица:");
PrintMatrix(result);

int[,] GenerateRandomMatrix(int rows, int columns)
{
    Random random = new Random();
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(10); // генерация случайного числа от 0 до 9
        }
    }

    return matrix;
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);

    int[,] result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int k = 0; k < columns1; k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}