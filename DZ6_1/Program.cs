// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Введите размер массива: ");
int numbers = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[] array = new int[numbers];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"Введите значение {i}: ");
    array[i]=Convert.ToInt32(Console.ReadLine());
    
    if (array[i] > 0)
        count++;
    }

System.Console.WriteLine($"Колличество введённых чисел больше нуля равно: {count}");