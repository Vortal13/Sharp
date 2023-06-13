// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


System.Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = 2;    
// т.к. нужны только чётные то 0 и 1 не подходят  
while (count <= number)
{
System.Console.Write($"{count} ");
count = count + 2;
}