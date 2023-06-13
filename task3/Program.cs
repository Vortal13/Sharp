// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 ->  "-2, -1, 0, 1, 2"

System.Console.Write("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = 0;
while (count <= 2*N)
{
    System.Console.Write($"{-N + count}, ");
    count++;
}