// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет



void PatrulQuater(int numberA, int numberB)
{
    if (numberA == numberB * numberB || numberB == numberA * numberA)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}


Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
PatrulQuater(numberA, numberB);
