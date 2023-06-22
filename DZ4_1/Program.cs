// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double pow = numberA;
for (int i = 1; i < numberB; i++)

    pow = pow * numberA;

System.Console.WriteLine($"Возведение числа {numberA} в степень {numberB} равно {pow}");
