// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void FillMatrixWithRandom(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j]}\t ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int[,] Multiplication(int[,] firstM, int[,] secondM)
{
    int[,] multMatrix = new int[firstM.GetLength(0), secondM.GetLength(1)];
    for (int i = 0; i < firstM.GetLength(0); i++)
    {
        for (int j = 0; j < secondM.GetLength(1); j++)
        {
            for (int k = 0; k < secondM.GetLength(0); k++)
            {
                multMatrix[i, j] += firstM[i, k] * secondM[k, j];
            }
        }
    }
    return multMatrix;
}

System.Console.Write("Введите количество строк первой матрицы: ");
int rowFirst = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("Введите количество столбцов первой матрицы: ");
int columnFirst = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,] firstM = new int[rowFirst, columnFirst];
FillMatrixWithRandom(firstM);
System.Console.WriteLine();
PrintMatrix(firstM);

System.Console.Write("Введите количество строк второй матрицы: ");
int rowSecond = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("Введите количество столбцов второй матрицы: ");
int columnSecond = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,] secondM = new int[rowSecond, columnSecond];
FillMatrixWithRandom(secondM);
System.Console.WriteLine();
PrintMatrix(secondM);

if (columnFirst == rowSecond)
{
    System.Console.WriteLine("Результат произведения: ");
    PrintMatrix(Multiplication(firstM, secondM));
}
else System.Console.WriteLine("Такие матрицы перемножать нельзя!");