// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void ArithmeticMean(int[,] matrix)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result += matrix[i, j];
        }
        result = (result / matrix.GetLength(0));
        result = Math.Round(result, 2);
        System.Console.Write($"{result}\t");

    }

}

System.Console.Write("Введите количество строк: ");
int row = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("Введите кол-во столбцов: ");
int column = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
ArithmeticMean(matrix);