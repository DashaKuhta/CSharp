    class Program
    {
        static void Main()
        {
            // Ввод размера матрицы
            Console.Write("Введите размерность матрицы (n x n): ");
            int n = int.Parse(Console.ReadLine());

            // Создание и заполнение матрицы
            int[,] A = new int[n, n];
            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Поиск столбцов, элементы которых образуют убывающую последовательность
            Console.WriteLine("Столбцы, образующие убывающую последовательность:");
            for (int j = 0; j < n; j++)
            {
                bool isDecreasing = true;
                if (n > 1) // Проверяем, что в столбце есть хотя бы 2 элемента
                {
                    for (int i = 1; i < n; i++)
                    {
                        if (A[i, j] >= A[i - 1, j])
                        {
                            isDecreasing = false;
                            break;
                        }
                    }
                }
                if (isDecreasing)
                {
                    Console.WriteLine($"Столбец {j + 1}");
                }
            }
        }
    }