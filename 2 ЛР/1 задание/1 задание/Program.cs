class Program
{
    static void Main()
    {
        Console.Write("Введите возраст человека в годах: ");
        string input = Console.ReadLine(); // Чтение строки ввода пользователя

        // Пробуем преобразовать строку в число
        int age = int.Parse(input);  // Это более простой, но менее безопасный способ

        // Определение возрастной категории
        if (age < 1)
        {
            Console.WriteLine("младенец");
        }
        else if (age <= 11)
        {
            Console.WriteLine("ребенок");
        }
        else if (age <= 15)
        {
            Console.WriteLine("подросток");
        }
        else if (age <= 25)
        {
            Console.WriteLine("юноша");
        }
        else if (age <= 70)
        {
            Console.WriteLine("мужчина");
        }
        else
        {
            Console.WriteLine("пожилой человек");
        }
    }
}