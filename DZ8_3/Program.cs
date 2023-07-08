// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillMatrixWithRandom(int[,,] matrix3D)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
}

void PrintMatrix(int[,,] matrix3D)
{
    for (int k = 0; k < matrix3D.GetLength(2); k++)
    {
        System.Console.WriteLine("Матрица №:" + (k + 1));
        for (int i = 0; i < matrix3D.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3D.GetLength(1); j++)
            {
                System.Console.Write($"{matrix3D[i, j, k]}({i}, {j}, {k})\t ");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}


System.Console.Write("Введите количество строк: ");
int row = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("Введите кол-во столбцов: ");
int column = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("Введите количество матриц: ");
int list = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[,,] matrix3D = new int[row, column, list];
FillMatrixWithRandom(matrix3D);
System.Console.WriteLine();
PrintMatrix(matrix3D);

