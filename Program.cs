using System;

namespace GuessNumber
{
    class Program
    {
        static void Main()
        {
            GuessGame game = new GuessGame();
            int attempts = 0;
            int guess = 0;

            Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");

            while (true)
            {
                Console.Write("Введите число: ");

                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Введите корректное число!");
                    continue;
                }

                attempts++;
                string result = game.CheckGuess(guess);

                if (result == "Угадал")
                {
                    Console.WriteLine($"Поздравляю! Ты угадал за {attempts} попыток.");
                    break;
                }
                else
                {
                    Console.WriteLine(result);
                }
            }

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}