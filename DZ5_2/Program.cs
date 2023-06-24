// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] ArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;

}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = ArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));

int amount = 0;
for (int i = 1; i < array.Length; i += 2)
{
    
    amount +=  array[i];  
}
System.Console.WriteLine($"Сумма чисел на нечётных позициях равна {amount}");

