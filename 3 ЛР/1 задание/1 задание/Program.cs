// Перебираем все двухзначные числа
for (int number = 10; number < 100; number++)
{
    // Извлекаем цифры числа
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    // Проверяем, все ли цифры разные
    if (firstDigit != secondDigit)
    {
        // Выводим число
        Console.WriteLine(number);
    }
}