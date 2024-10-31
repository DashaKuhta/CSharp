using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Ввод текстового сообщения
        Console.Write("Введите текстовое сообщение: ");
        string message = Console.ReadLine();

        // Заменить английские слова на многоточие
        // ReplaceEnglishWords(message) отвечает за замену всех английских слов в строке message на многоточие
        string result = ReplaceEnglishWords(message);

        // Вывод результата
        Console.WriteLine("Результат:");
        Console.WriteLine(result);
    }

    static string ReplaceEnglishWords(string text)
    {
        // Регулярное выражение для поиска английских слов
        string pattern = @"\b[a-zA-Z]+\b";

        // Замена английских слов на многоточие
        return Regex.Replace(text, pattern, "...");
    }
}