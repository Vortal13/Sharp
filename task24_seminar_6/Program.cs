// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


bool IsTrDo(int numA, int numB, int numC)
{
    if (numA < numB + numC && numB < numA + numC && numC < numA + numB)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.Write("Введите первую сторону треугольника: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите вторую сторону треугольника: ");
int numB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третью сторону треугольника: ");
int numC = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine(IsTrDo(numA , numB, numC));



System.Console.WriteLine();