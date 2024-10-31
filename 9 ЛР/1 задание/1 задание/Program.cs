class StringManipulator
{
    private string line;

    // Конструктор
    public StringManipulator(string input)
    {
        line = input;
    }

    // Свойство для получения общего количества символов
    public int Length => line.Length;

    // Индексатор для доступа к символу по индексу
    public char this[int index]
    {
        get
        {
            if (index < 0 || index >= line.Length)
                throw new IndexOutOfRangeException("Индекс находится вне диапазона строки.");
            return line[index];
        }
    }

    // Метод для подсчета количества цифр в строке
    public int CountDigits()
    {
        return line.Count(char.IsDigit);
    }

    // Метод для вывода уникальных символов  (те которые встречаются только один раз)
    public void PrintUniqueChars()   //PrintUniqueChars() Выводит уникальные символы.
    {
        var uniqueChars = line.GroupBy(c => c)
                              .Where(g => g.Count() == 1)
                              .Select(g => g.Key);

        Console.WriteLine("Уникальные символы: " + string.Join(", ", uniqueChars));
    }

    // Метод для вывода самой длинной последовательности повторяющихся символов
    public void PrintLongestRepeatingSequence()   //PrintLongestRepeatingSequence( ) Находит и выводит самую длинную последовательность 
    {
        int maxLength = 0;
        char maxChar = ' ';

        int currentLength = 1;

        for (int i = 1; i < line.Length; i++)
        {
            if (line[i] == line[i - 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxChar = line[i - 1];
                }
                currentLength = 1;
            }
        }

        // Проверка последней последовательности
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxChar = line[line.Length - 1];
        }

        if (maxLength > 0)
        {
            Console.WriteLine($"Самая длинная последовательность: '{new string(maxChar, maxLength)}' (длина {maxLength})");
        }
        else
        {
            Console.WriteLine("Нет повторяющихся символов.");
        }
    }

    // Перегрузка унарного оператора !
    public static bool operator !(StringManipulator sm)
    {
        return string.IsNullOrEmpty(sm.line);
    }

    // Перегрузка константы true для проверки на палиндром
    public static implicit operator bool(StringManipulator sm)   //Оператор bool Проверяет, является ли строка палиндромом.
    {
        var cleanedLine = new string(sm.line.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();
        return cleanedLine.SequenceEqual(cleanedLine.Reverse());
    }

    // Перегрузка оператора &
    public static bool operator &(StringManipulator sm1, StringManipulator sm2) //Оператор & Сравнивает две строки без учета регистра.
    {
        return string.Equals(sm1.line, sm2.line, StringComparison.OrdinalIgnoreCase);
    }

    // Перегрузка явного преобразования в string
    public static explicit operator string(StringManipulator sm)
    {
        return sm.line;
    }

    // Перегрузка неявного преобразования из string
    public static implicit operator StringManipulator(string input)
    {
        return new StringManipulator(input);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        StringManipulator strManipulator = new StringManipulator(input);

        // Подсчёт количества цифр
        int digitCount = strManipulator.CountDigits();
        Console.WriteLine($"Количество цифр в строке: {digitCount}");

        // Вывод уникальных символов
        strManipulator.PrintUniqueChars();

        // Вывод самой длинной последовательности повторяющихся символов
        strManipulator.PrintLongestRepeatingSequence();

        // Демонстрация перегрузки унарного оператора !
        Console.WriteLine($"Строка не пустая? {!strManipulator}");

        // Демонстрация проверки на палиндром
        Console.WriteLine($"Строка является палиндромом? {strManipulator}");

        // Демонстрация перегрузки оператора &
        StringManipulator anotherManipulator = new StringManipulator("Тест");
        Console.WriteLine($"Строки одинаковы (без учета регистра)? {strManipulator & anotherManipulator}");

        // Демонстрация приведения типа
        string normalString = (string)strManipulator;
        Console.WriteLine($"Строка в обычном виде: {normalString}");
    }
}
