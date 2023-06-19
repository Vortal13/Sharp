// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


System.Console.Write("Введите пятизначное число: ");
string? num = Console.ReadLine();
int length = num.Length ;
// определение размера числа

if (length == 5)

    if (num[0] == num[4] && num[1] == num[3])
        System.Console.WriteLine("Введённое число является палиндромом");
    else
        System.Console.WriteLine("Введённое число не является палиндромом");

else

    System.Console.WriteLine("Введённое число не пятизначное");

