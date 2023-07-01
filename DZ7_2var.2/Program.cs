// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

bool CheckNumber(int[,] matrix, int numberRow, int numberColumn)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == numberRow && j == numberColumn)
            {
                return true;
            }
        }
    }
    return false;
}

void PositionValue(int[,] matrix, int numberRow, int numberColumn)
{
    int num = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == numberRow && j == numberColumn)
            {
                num = matrix[i, j];
                System.Console.Write($"Заданное число на позиции {(numberRow, numberColumn)} равно {num}");
            }
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrixWithRandom(matrix);
PrintMatrix(matrix);
System.Console.Write("Введите номер строки для поиска: ");
int numberRow = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер столбца для поиска: ");
int numberColumn = Convert.ToInt32(Console.ReadLine());

if (CheckNumber(matrix, numberRow, numberColumn))
    PositionValue(matrix, numberRow, numberColumn);
else
    System.Console.WriteLine("Такой позиции в заданной матрице нет.");
