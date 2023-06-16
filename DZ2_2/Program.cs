// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Пример:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.Write("Введите число для проверки: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int Digit3(int number)
{
while (number > 999)
    number = number / 10;
int result = number % 10;
return result;
}
if ((number >= 0) && (number < 100))

    System.Console.WriteLine("В введённом числе отсутствует третья цифра.");
else
   System.Console.WriteLine("Третья цифра равна:" + Digit3(number));





// string num = "123";
// if (int.TryParse(num, out int number))
// {
//     System.Console.WriteLine(num[2]);
// }
// else
// {
//     System.Console.WriteLine("не число");
// }


