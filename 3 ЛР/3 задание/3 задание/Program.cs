


class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя ввод значения переменной a
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("h= ");
        double h = double.Parse(Console.ReadLine());

        double y; // Переменная для хранения значения функции f(x)
        int i = 1; // Счетчик для вывода номера строки

        // Вывод заголовка таблицы
        Console.WriteLine("{0,3} {1,5} {2,5}", "#", "x", "f(x)");

        // Цикл для вычисления значений функции от a до b с шагом h
        for (double x = a; x <= b; x += h, ++i)
        {
            // Если x меньше 0, рассчитываем y по одной формуле
            if (x < 0)
            {
                y = Math.Pow(Math.Pow(x, 3) + 1, 2);
            }
            else
            {
                // Если x меньше 1, y равен 0
                if (x < 1)
                {
                    y = 0;
                }
                else // Если x больше или равен 1, используем другую формулу
                {
                    y = Math.Abs(x * x - 5 * x + 1);
                }
            }
            // Вывод значений: номер строки, x и соответствующее значение функции y
            Console.WriteLine("{0,3} {1,5:f2} {2,5:f2}", i, x, y);
        }
    }
}