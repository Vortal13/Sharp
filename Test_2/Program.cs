// Было: 6 8 3 2 1 4 5 7
// Результат: 1 2 3 4 5 6 7 8
// Найти позицию минимального элемента в неотсортированной части массива.
// Произвести обмен этого значения со значением первой неотсортированной позиции.
// Повторять пока есть неотсортированные элементы.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 3 };
//  Введение\определение массива

void PrintArray(int[] array)
// метод для вывода массива
{
    int count = array.Length;
    //  определяем длинну массива
    for (int i = 0; i < count; i++)
    // цикл для показа всех элементов на экране
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
// метод для упорядочивания массива
{
    for (int i = 0; i < array.Length - 1; i++)
    // для полного кол-ва элементов <-1>
    {
        int minPosition = i;
        // Определяем позицию как минимальную
        for (int j = i + 1; j < array.Length; j++)
        // поиск миннимальной позиции, не касаясь уже пройденой поэтому (i+1)
        {
            if (array[j] < array[minPosition]) minPosition = j;
            // если позиция меньше текущей, то сохраняем её в <minPosition>
        }
        int temporary = array[i];
        // присвоение переменной значения действующей позиции i
        array[i] = array[minPosition];
        // замена значения в точке i на полученное значение  в <minPosition>
        array[minPosition] = temporary;
        // замена значения в точке <minPosition> на временное значение  в <temporary>
    }

}
PrintArray(arr);
// Вывод результата
SelectionSort(arr);

PrintArray(arr);