// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> не

System.Console.Write("Введите порядковый номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if ((day == 6) || (day == 7))
    System.Console.WriteLine("День является выходным");
else if ((day <= 0) || (day > 7))
    System.Console.WriteLine("Такого дня недели не существует");
else
    System.Console.WriteLine("День не является выходным");

