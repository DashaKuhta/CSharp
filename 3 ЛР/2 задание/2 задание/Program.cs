

class Program
{
    static void Main()
    {
        // Внешний цикл выполняется 4 раза (от 0 до 3), 
        // i будет принимать значения 0, 1, 2 и 3
        for (int i = 0; i < 4; i++)
        {
            // Внутренний цикл для печати текущего значения i + 1
            // Например, когда i = 0, он печатает 1 раз, когда i = 1 - 2 раза и так далее
            for (int j = 0; j <= i; j++)
            {
                Console.Write(i + 1 + " "); // Печать i + 1 с пробелом
            }

            Console.WriteLine(); 

            for (int k = 0; k <= i; k++)
            {
                Console.Write(i + 6 + " "); // Печать i + 6 с пробелом
            }

            Console.WriteLine(); 
        }
    }
}