class Program
{
    static void Main()
    {
        Console.Write("Введите количество элементов в массиве: ");
        int n = int.Parse(Console.ReadLine()); // Считываем и преобразуем ввод в целое число

        // Создаем массив размером n
        int[] array = new int[n];

        // Заполняем массив элементами, запрашивая их у пользователя
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элемент {i + 1}: "); 
            array[i] = int.Parse(Console.ReadLine()); // Считываем и сохраняем элемент в массив
        }

        int maxElement = array[0]; // Начальное значение для максимального элемента
        int minElement = array[0]; // Начальное значение для минимального элемента

        // Проходим по массиву, начиная со второго элемента
        for (int i = 1; i < array.Length; i++)
        {
            // Проверяем, является ли текущий элемент больше максимального
            if (array[i] > maxElement)
            {
                maxElement = array[i]; // Обновляем максимальный элемент
            }

            // Проверяем, является ли текущий элемент меньше минимального
            if (array[i] < minElement)
            {
                minElement = array[i]; // Обновляем минимальный элемент
            }
        }

        // Вычисляем разность между максимальным и минимальным элементами
        int difference = maxElement - minElement;

        Console.WriteLine($"Разность максимального и минимального элементов: {difference}");
    }
}