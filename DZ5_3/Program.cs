// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int[] ArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = ArrayWithRandomNumber(length);
int minElement = 10;
// принимаем переменную minElement за максимальное значение в диапазоне массива
int maxElement = 1;
// принимаем переменную maxElement за минимальное значение в диапазоне массива

foreach (var i in array)
    //  перебираем все позиции на меньшее значение

    if (i < minElement)
    {
        minElement = i;
    }

foreach (var i in array)
    //  перебираем все позиции на большее значение

    if (i > maxElement)
    {
        maxElement = i;
    }
int difference = maxElement - minElement;
System.Console.WriteLine(string.Join("; ", array));

System.Console.WriteLine($"Разница между максимальным ({maxElement}) и минимальным ({minElement}) элементом массива равна: {difference}");


