using System.Text; // Необходим для использования StringBuilder
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine();

        // Вызываем метод для обработки строки и получения результата
        string result = SwapCharacters(input);

        Console.WriteLine($"Результат: \"{result}\"");
    }

    static string SwapCharacters(string s)
    {
        // Создаем новый экземпляр StringBuilder для построения новой строки
        StringBuilder stringBuilder = new StringBuilder(s);

        // Определяем длину строки
        int length = stringBuilder.Length;

        // Итерируемся наполовину длины строки
        for (int i = 0; i < length / 2; i++)
        {
            // Меняем местами символы на позиции i и (length - 1 - i)
            char temp = stringBuilder[i]; // Сохраняем текущий символ
            stringBuilder[i] = stringBuilder[length - 1 - i]; // Заменяем его на символ с конца строки
            stringBuilder[length - 1 - i] = temp; // Возвращаем сохраненный символ в конец
        }

        // Преобразуем StringBuilder обратно в строку и возвращаем результат
        return stringBuilder.ToString();
    }
}