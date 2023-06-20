// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
// string num = number.ToString();
// System.Console.WriteLine(num.Length);

//  Метод 1
// System.Console.WriteLine("Введите целое число");
// int number = Convert.ToInt32(Console.ReadLine());
// int DigitCapacity(int num)
// {
//     int digitCapacity = 0;
//     int buff = 0;
//     if (num == 0)
//     {
//         digitCapacity = 1;        
//     return digitCapacity;   
//     }    
//     else
//    {
//     for (int i = 1; buff != num; i *= 10)
//     {
//     buff = buff + i * ((num / i) % 10);
//      digitCapacity++;
//     }
//     return digitCapacity;
//     }
// }
// System.Console.WriteLine($"Количество разрядов числа {number} - {DigitCapacity(number)}");

// Метод 2

int CountingDigit(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (CountingDigit(number) == 0)
{
    System.Console.WriteLine("1");
}
else
{
    System.Console.WriteLine(CountingDigit(number));
}