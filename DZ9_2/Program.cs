// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumbersSumMN(int m, int n)
{
    int sum = m;
    if (m == n)
    {
        return n;
    }
    m += 1;
    return sum += NumbersSumMN(m, n);
}

int NumbersSumNM(int m, int n)
{
    int sum = n;
    if (n == m)
    {
        return m;
    }
    n += 1;
    return sum += NumbersSumNM(m, n);
}

System.Console.Write("Введите первое число: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("Введите второе число: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (m < n)
    System.Console.Write(NumbersSumMN(m, n));
else
    System.Console.Write(NumbersSumNM(m, n));
