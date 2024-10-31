class Program
{
    // Метод для проверки, представляют ли цифры числа строго возрастающую последовательность
    static int IsStrictlyIncreasing(int number)
    {
        // Если число отрицательное, то просто возвращаем 0
        if (number < 0) return 0;

        int previousDigit = 10; // Начальное значение для сравнения (больше 9, так как максимальная цифра 9)

        while (number > 0)
        {
            int currentDigit = number % 10; // Получаем последнюю цифру числа
            number /= 10; // Убираем последнюю цифру числа

            // Если текущая цифра не меньше или равна предыдущей, то последовательность не строго возрастающая
            if (currentDigit >= previousDigit)
                return 0;

            // Обновляем предыдущую цифру
            previousDigit = currentDigit;
        }

        return 1; // Если все цифры были строго возрастающими
    }

    static void Main()
    {
        Console.WriteLine("Введите последовательность целых чисел (0 для завершения):");

        while (true)
        {
            int input = int.Parse(Console.ReadLine());

            // Завершаем ввод при получении 0
            if (input == 0)
                break;

            int result = IsStrictlyIncreasing(input);
            Console.WriteLine(result); // Выводим 1 или 0 в зависимости от результата
        }
    }
}