// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
{ System.Console.WriteLine($"Число {numA} больше числа {numB}"); }
else
{ System.Console.WriteLine($"Число {numB} больше числа {numA}"); }
