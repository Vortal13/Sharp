// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void RoadToNumber(int number, int num)
{
    if (num > number)
    {
        return;
    }
    RoadToNumber(number, num + 1);
    System.Console.Write($"{num} ");
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = 1;
RoadToNumber(number, num);
