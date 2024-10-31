class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя количество элементов в массиве
        Console.Write("Введите количество элементов в массиве: ");
        int size = int.Parse(Console.ReadLine());

        // Создаем массив заданного размера
        int[] X = new int[size];

        // Заполняем массив элементами, введенными пользователем
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < size; i++)
        {
            X[i] = int.Parse(Console.ReadLine());
        }

        // Вывод исходного массива
        Console.WriteLine("Исходный массив: " + string.Join(", ", X));

        // Находим индекс минимального элемента
        int minIndex = Array.IndexOf(X, X.Min());
        // Находим индекс первого элемента
        int firstIndex = 0;

        // Меняем местами первый и минимальный элементы
        int temp = X[firstIndex];
        X[firstIndex] = X[minIndex];
        X[minIndex] = temp;

        // Вывод массива после обмена
        Console.WriteLine("Массив после обмена: " + string.Join(", ", X));

        // Находим индекс максимального элемента
        int maxIndex = Array.IndexOf(X, X.Max());

        // Удаляем все простые элементы, стоящие после максимального элемента        
        //Take(maxIndex + 1) возвращает новую последовательность, содержащую элементы от начала массива X до элемента
        //с индексом maxIndex + 1 (включительно).
        X = X.Take(maxIndex + 1).Concat(X.Skip(maxIndex + 1).Where(IsNotPrime)).ToArray();

        // Вывод массива после удаления простых элементов
        Console.WriteLine("Массив после удаления простых элементов: " + string.Join(", ", X));

        // Находим среднее арифметическое до и после удаления
        double averageBefore = CalculateAverage(new int[size]);
        double averageAfter = CalculateAverage(X);

        // Вывод средних арифметических
        Console.WriteLine($"Среднее арифметическое до удаления: {averageBefore}");
        Console.WriteLine($"Среднее арифметическое после удаления: {averageAfter}");
    }

    // Метод для проверки является ли число простым
    static bool IsNotPrime(int number)
    {
        if (number <= 1) return true; // 0 и 1 не простые
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return true; // не простое
        }
        return false; // простое
    }

    // Метод для вычисления среднего арифметического
    static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0) return 0; // Избегаем деления на ноль
        return (double)numbers.Sum() / numbers.Length;
    }
}