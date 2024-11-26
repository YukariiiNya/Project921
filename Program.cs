using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа для суммы. Для завершения введите 'exit':");
        double sum = 0;

        while (true)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (input?.ToLower() == "exit")
            {
                break;
            }

            try
            {
                double number = double.Parse(input);
                sum += number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введенное число слишком большое.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
        }

        Console.WriteLine($"Сумма введенных чисел: {sum}");
    }
}
