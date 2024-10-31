class Program
{
    static double f(double x1, double y1, double x2, double y2)
    {
        // Используем формулу расстояния между двумя точками
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    // Метод для вычисления периметра треугольника по длинам сторон
    static double d(double a, double b, double c)
    {
        return a + b + c;
    }

    static void Main()
    {
        // Вводим координаты вершин треугольника
        Console.WriteLine("Введите координаты первой вершины (x1, y1):");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты второй вершины (x2, y2):");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты третьей вершины (x3, y3):");
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        // Вычисляем длины сторон треугольника
        double a = f(x1, y1, x2, y2); // Сторона между вершинами 1 и 2
        double b = f(x2, y2, x3, y3); 
        double c = f(x3, y3, x1, y1); // Сторона между вершинами 3 и 1

        // Вычисляем периметр треугольника
        double perimeter = d(a, b, c);

        Console.WriteLine("Периметр треугольника: " + perimeter);
    }
}