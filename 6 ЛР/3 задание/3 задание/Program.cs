using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите текстовое сообщение: ");
        string input = Console.ReadLine(); 

        // Вызываем метод для поиска самых коротких слов
        List<string> shortestWords = FindShortestWords(input);

        // Выводим результат 
        if (shortestWords.Count > 0)
        {
            Console.WriteLine("Самые короткие слова:");
            foreach (string word in shortestWords)
            {
                Console.WriteLine(word);
            }
        }
        else
        {
            Console.WriteLine("Нет слов в сообщении.");
        }
    }
    // Метод для поиска самых коротких слов в строке
    static List<string> FindShortestWords(string message)
    {
        // Используем StringBuilder для обработки строки
        StringBuilder stringBuilder = new StringBuilder(message);

        // Заменяем знаки препинания на пробелы для корректного разбиения на слова
        foreach (char punctuation in new char[] { ',', '.', '!', '?', ';', ':' })
        {
            stringBuilder.Replace(punctuation, ' '); // Заменяем знак препинания на пробел
        }

        // Преобразуем результат в строку и разбиваем на слова
        string[] words = stringBuilder.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Находим минимальную длину слова
        int minLength = words.Min(w => w.Length);

        // Создаем список для хранения самых коротких слов
        List<string> shortestWords = new List<string>();

        // Добавляем слова, соответствующие минимальной длине
        foreach (string word in words)
        {
            if (word.Length == minLength)
            {
                shortestWords.Add(word);
            }
        }
        // Возвращаем список самых коротких слов
        return shortestWords;
    }
}