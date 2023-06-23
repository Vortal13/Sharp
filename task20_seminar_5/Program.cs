// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет 1 раз
// -3; массив [6, 7, 19, 345, 3] -> да 1 раз

int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

bool CheckNumber(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (number == arr[i])
        {
            return true;
        }
    }
    return false;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckNumber(array, number))
{
    System.Console.WriteLine("Элемент найден");
}
else
{
    System.Console.WriteLine("Элемент НЕ найден");
}

// Вариант 2

// string isOk = "Элемент НЕ найден";
// for (int i = 0; i < array.Length; i++)
// {
//     if (number == array[i])
//     {
//         isOk = "Элемент найден";
//         break;
//     }
// }
// System.Console.WriteLine(isOk);



// Решение №3
// int[] FillArrayWithRandomNumber(int size)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(-9, 10);
//     }
//     return arr;
// }

// System.Console.Write("Введите кол-во элементов массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWithRandomNumber(length);
// System.Console.WriteLine(string.Join("; ", array));

// System.Console.Write("Введите цифру: ");
// int digit = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == digit)
//     {
//         count = count + 1;   
//     }
// }
// if (count > 0)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }