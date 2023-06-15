// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трёхзначное число для проверки: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = (number - (number / 100) * 100 - (number % 10)) / 10;

if ((number < 100) || (number >= 1000))

    System.Console.WriteLine("Введённое число не трёхзначное.");

else

    System.Console.WriteLine("Вторая цифра введённого числа:" + result);