//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.



// int[] first = new int[] { 0, 5, 1, 4, 6, 777, 64 };
// int[] second = new int[first.Length];

// int[] MakeMagic(int[] first, int[] second)
// {
//     for (int i = 0; i < first.Length; i++)
//     {
//         second[i] = first[i];
//     }
//     return second;
// }

// System.Console.WriteLine(string.Join("; ", first));

// System.Console.WriteLine(string.Join("; ", MakeMagic(first, second)));



// Вариант №2
int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 10);
    }
    return arr;
}

void CopyArray(int[] arr, int[] newArr)
{
    for (int i = 0; i < newArr.Length; i++)
    {
        newArr[i] = arr[i];
    }
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));
int[] newArray = new int[array.Length];
CopyArray(array, newArray);
System.Console.WriteLine(string.Join("; ", newArray));