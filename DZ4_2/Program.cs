// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int num)
{
    int summ = 0;
    while (num > 0 || num < 0)
    {
        summ = summ +  num % 10;
        num /= 10;
        
    }
    return summ;
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (SumDigits(number) == 0)
{
    System.Console.WriteLine("0");
}
else
{
    System.Console.WriteLine(SumDigits(number));
}


