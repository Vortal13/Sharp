// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


void ToDouble (int num)
{
    if (num  == 0)
    {
        return;
    }
    int count = 0;
    count = num % 2;
    num = num /2;
    
    ToDouble (num);
    System.Console.Write(count);
}


System.Console.WriteLine("Введите число для перевода в двоичную систему: ");
int num = Convert.ToInt32(Console.ReadLine());

ToDouble(num);