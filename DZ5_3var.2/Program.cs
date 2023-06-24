// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] ArrayWithRandomNumber(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() + rnd.Next(0,100);
    }
    return arr;

}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = ArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

double minElement = 100;
// принимаем переменную minElement за максимальное значение в диапазоне массива
double maxElement = 0;
// принимаем переменную maxElement за минимальное значение в диапазоне массива

foreach (var i in array)
    //  перебираем все позиции на меньшее значение

    if (i < minElement)
    {
        minElement = Math.Round(i,3);
    }

foreach (var i in array)
    //  перебираем все позиции на большее значение

    if (i > maxElement)
    {
        maxElement = Math.Round(i,3);
    }
double difference = maxElement - minElement;
System.Console.WriteLine(string.Join("; ", array));
System.Console.WriteLine($"Разница между максимальным ({maxElement}) и минимальным ({minElement}) элементом массива равна: {difference}");