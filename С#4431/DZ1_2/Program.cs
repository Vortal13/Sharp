// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());

if (numA > numB && numA > numC)
    System.Console.WriteLine($"Наибольшее число: {numA}");
if (numB > numA && numB > numC)
    System.Console.WriteLine($"Наибольшее число: {numB}");
if (numC > numB && numC > numA)
    System.Console.WriteLine($"Наибольшее число: {numC}");