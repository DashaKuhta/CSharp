class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя ввод строки
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine(); 

        // Вызываем метод для подсчета суммы цифр в введенной строке
        int sum = CalculateSumOfDigits(input);

        Console.WriteLine($"Сумма всех цифр в строке: {sum}");
    }
    static int CalculateSumOfDigits(string s)
    {
        int sum = 0; // Переменная для хранения суммы цифр

        // Итерируемся по каждому символу в строке
        foreach (char c in s)
        {
            // Проверяем, является ли символ цифрой
            if (char.IsDigit(c))
            {
                // Преобразуем символ в цифру и добавляем к сумме
                sum += c - '0'; // '0' - это символ, соответствующий числу 0 в ASCII
            }
        }
        return sum;
    }
}