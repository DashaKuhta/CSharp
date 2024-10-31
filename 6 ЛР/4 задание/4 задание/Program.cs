class Program
{
    static void Main()
    {
        string poems = "тучки небесные, вечные странники...";
        char[] div = { ' ', ',', '.' }; // создаем массив разделителей

        // разбиваем строку на части
        string[] parts = poems.Split(div, StringSplitOptions.RemoveEmptyEntries); // 1

        Console.WriteLine("Результат разбиения строки на части:");
        foreach (var part in parts)
        {
            Console.WriteLine(part);
        }

        // переворачиваем массив слов
        Array.Reverse(parts);

        // собираем эти части в одну строку, в качестве разделителя используем символ |
        string whole = String.Join(" | ", parts);
        Console.WriteLine("Результат сборки:");
        Console.WriteLine(whole);
    }
}