// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunction(int m, int n)
{
    int sum = 0;
    if (m == 0)
    {
        return n + 1;
    }
   
    if (m > 0 && n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }

    if (m > 0 && n > 0)
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }

    return sum;
}

System.Console.Write("Введите первое число: ");
int m = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("Введите второе число: ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
System.Console.Write($"Результат равен: {AckermanFunction(m, n)}");