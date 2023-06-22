// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.Write("Введите размер массива: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[] array = new int[num];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100);
   
}
System.Console.WriteLine($"[{string.Join(", ", array)}]");