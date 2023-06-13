// Напишите программу, которая  принимает  на вход трехзначное и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = N % 10;
System.Console.WriteLine($"{N} -> {result}");