// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// System.Console.Write("Введите размер массива: ");
// int numbers = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// int[] array = new int[numbers];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write($"Введите значение {i}: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());

//     if (array[i] > 0)
//         count++;
// }

// System.Console.WriteLine($"Колличество введённых чисел больше нуля равно: {count}");


// Пример идеального решения
int Prompt(string message)   // считать число с консоли
{
    System.Console.Write(message);  // ввывести  сообщение
    string value = Console.ReadLine(); //считывает с консоли строку
    int result = Convert.ToInt32(value); // преобразование строки в целое число
    return result;
}

int[] InputArray(int lenght) // ввод массива
{
    int[] array = new int[lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-й элемент: ");
    }
    return array;
}

void PrintArray(int[] array) // вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositivNumbers(int[] array) //перебор значений в массиве на условие
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
return count;
}

int lenght = Prompt("Введите количество элементов: ");
int[] array;
array = InputArray(lenght);
PrintArray(array);
System.Console.WriteLine($"Колличество введённых чисел больше нуля равно: {CountPositivNumbers(array)}");