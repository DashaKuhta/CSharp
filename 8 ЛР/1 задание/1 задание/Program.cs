struct Customer
{
    public string LastName;
    public string FirstName;
    public string MiddleName;
    public string Address;
    public string PhoneNumber;
    public string CreditCardNumber;
}

class Program
{
    static void Main()
    {
        Customer[] customers = new Customer[100];
        int count = 0;

        // Заполняем массив данными
        customers[count++] = new Customer { LastName = "Иванов", FirstName = "Иван", MiddleName = "Иванович", Address = "пр. Пушкина, 3", PhoneNumber = "1234567890", CreditCardNumber = "1111-2222-3333-4444" };
        customers[count++] = new Customer { LastName = "Сидоров", FirstName = "Алексей", MiddleName = "Витальевич", Address = "ул. Южная, 14", PhoneNumber = "0987654321", CreditCardNumber = "4444-3333-2222-1111" };
        customers[count++] = new Customer { LastName = "Петров", FirstName = "Александр", MiddleName = "Антонович", Address = "ул. Белые Росы, 3", PhoneNumber = "5555555555", CreditCardNumber = "5555-6666-7777-8888" };

        PrintCustomers(customers, count); // Выводим заполненный массив

        // Удаляем K элементов из начала массива
        int K = 1; // Количество удаляемых элементов
        count = RemoveCustomers(customers, count, K);

        Console.WriteLine($"\nПосле удаления {K} элементов:");
        PrintCustomers(customers, count);

        // Вводим количество добавляемых элементов с клавиатуры
        Console.Write("Введите количество добавляемых элементов: ");
        int N;
        while (!int.TryParse(Console.ReadLine(), out N) || N < 1)
        {
            Console.WriteLine("Пожалуйста, введите положительное число.");
        }

        AddCustomers(customers, ref count, N);

        Console.WriteLine($"\nПосле добавления {N} новых элементов:");
        PrintCustomers(customers, count);
    }

    static void PrintCustomers(Customer[] customers, int count)
    {
        Console.WriteLine("Список покупателей:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Фамилия: {customers[i].LastName}, Имя: {customers[i].FirstName}, Отчество: {customers[i].MiddleName}, " +
                              $"Адрес: {customers[i].Address}, Телефон: {customers[i].PhoneNumber}, Номер карты: {customers[i].CreditCardNumber}");
        }
    }

    static int RemoveCustomers(Customer[] customers, int count, int K)
    {
        if (K >= count)
        {
            return 0; // Если K больше или равно количеству, возвращаем 0
        }

        for (int i = K; i < count; i++)
        {
            customers[i - K] = customers[i]; // Сдвигаем элементы влево
        }

        return count - K; // Возвращаем новую длину массива
    }

    static void AddCustomers(Customer[] customers, ref int count, int N)
    {
        for (int i = 0; i < N; i++)
        {
            customers[count++] = new Customer
            {
                LastName = $"Иванов{i + 1}",
                FirstName = $"Василий{i + 1}",
                MiddleName = $"Викторович{i + 1}",
                Address = $"пр. Клецкова, {i + 1}",
                PhoneNumber = $"7777777{i}",
                CreditCardNumber = $"9999-8888-7777-{i + 1}999"
            };
        }
    }
}