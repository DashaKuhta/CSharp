class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());
        double y;

        // Проверяем условие первой ветви
        if (x < 0)
        {
            y = Math.Pow(Math.Pow(x, 3) + 4, 2);
        }
        else
        {
            // Проверяем условие второй ветви
            if (x < 1)
            {
                y = 0;
            }
            else
            {
                double numerator = 3 * x + 4;
                double denominator = Math.Sqrt(x * x + 2 * x + 1);
                y = numerator / denominator;
            }
        }

        Console.WriteLine($"y({x:f2})={y:f2}");
    }
}