class Program
{
    static void Main()
    {
        // Запрос суммы вклада у пользователя
        Console.Write("Введите сумму вклада: ");
        double symma = Convert.ToDouble(Console.ReadLine());

        // Запрос процента по вкладу у пользователя
        Console.Write("Введите процент по вкладу: ");
        double prosent = Convert.ToDouble(Console.ReadLine());

        // Вычисление итоговой суммы 
        double nachiclProsent = symma * (prosent / 100);
        double itogSymma = symma + nachiclProsent;

        // Вывод результата на экран
        Console.WriteLine($"Итоговая сумма вклада за год: {itogSymma} p ");
    }
}