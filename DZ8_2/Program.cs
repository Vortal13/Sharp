// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillMatrixWithRandom(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t ");
        }
        System.Console.WriteLine();
    }
}

int SumRowElements(int[,] matrix)
{
    int[] sumResult = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumResult[i] += matrix[i, j];
        }
    }
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (sumResult[i] < sumResult[result]) result = i;
    }
    return result;
}

System.Console.Write("Введите количество строк: ");
int row = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("Введите кол-во столбцов: ");
int column = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine($"Наименьшая сумма элементов находится в {SumRowElements(matrix)} строке.");