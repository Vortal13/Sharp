//               Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.


string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replase(string text, char oldValue, char newValue)
// начало метода имя-Replase, берём text, меняем старый символ на новый символ
{
    string result = String.Empty;
    // инициализация пустой строки 
    int lenght = text.Length;
    // определение длинны строки text
    for (int i = 0; i < lenght; i++)
    // начало цикла с позиции 0 до длинны строки по одному шагу
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        //  если символ на позиции i совпадает с oldValue(символ который нужно заменить), то в результате меняем на newValue
        else result = result + $"{text[i]}";
        //  если нет, записываем как есть

    }

    return result;
    // возврат результата
}

string newText = Replase(text, ' ', '|');
// Определяем новый текст с изменением пробелов на черточки
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replase(newText, 'к', 'К');
System.Console.WriteLine(newText);
System.Console.WriteLine();
newText = Replase(newText, 'В', 'в');
System.Console.WriteLine(newText);