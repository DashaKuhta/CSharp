class Program
{
    static void Main()
{
    // Ввод координат вершин треугольника
    Console.Write("Введите x1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите x3: ");
    double x3 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите y3: ");
    double y3 = Convert.ToDouble(Console.ReadLine());

    // Вычисление длины сторон треугольника     Math.Pow - возведение в степень
    double a = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)); // Длина стороны между (x2, y2) и (x3, y3)
    double b = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)); // Длина стороны между (x1, y1) и (x3, y3)
    double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // Длина стороны между (x1, y1) и (x2, y2)

    // Вычисление периметра
    double perimeter = a + b + c;

    // Вывод результата
    Console.WriteLine($"Периметр треугольника: {perimeter}");
}
}