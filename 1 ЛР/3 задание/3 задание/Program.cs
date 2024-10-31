class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        string input = Console.ReadLine();

        if (input.Length == 3) // Проверка, состоит ли введенная строка из трех символов
        {
            char firstDigit = input[0]; // Извлекаем первую цифру как символ
            char secondDigit = input[1]; // Извлекаем вторую цифру как символ

            // Используем тернарный оператор для определения результата
            string result = (firstDigit > secondDigit) ? "Первая цифра больше второй."
                         : (firstDigit < secondDigit) ? "Вторая цифра больше первой."
                         : "Цифры равны.";

            Console.WriteLine(result); // Выводим результат
        }
        else
        {
            Console.WriteLine("Введите корректное трехзначное число."); // Выводим сообщение об ошибке      
        }
    }
}