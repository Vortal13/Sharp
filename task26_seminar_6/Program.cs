// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fib(int N)
{
    int first = 0;
    System.Console.Write($" {first}");
    int second = 1;
    System.Console.Write($"; {second}");
    for (int i = 0; i < N-2; i++)
    {
        int fib = first + second;
        first = second;
        second = fib;
        System.Console.Write($"; {fib}");
    }
}

System.Console.Write("Введите колличество чисел фибоначи: ");
int N = Convert.ToInt32(Console.ReadLine());

Fib(N);