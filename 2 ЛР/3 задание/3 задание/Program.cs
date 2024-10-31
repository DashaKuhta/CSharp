class Program
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());

        const int radiusOuter = 1;
        const int radiusInner = -1;

        double distanceFromOrigin = Math.Sqrt(x * x + y * y);

        if (distanceFromOrigin < radiusOuter && distanceFromOrigin > radiusInner && x > -1 && x < 1)
        {
            Console.WriteLine("да");
        }
        else if (distanceFromOrigin == radiusOuter || distanceFromOrigin == radiusInner || x == -1 || x == 1)
        {
            Console.WriteLine("на границе");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
}
