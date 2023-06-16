// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).


string[] text = {"x > 0; y > 0",
                "x < 0; y > 0",
                "x < 0; y < 0",
                "x > 0; y < 0"};
System.Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 && num <= 4)
    System.Console.WriteLine(text[num - 1]);
else
    System.Console.WriteLine("Введенное занчение не является номером четверти");
