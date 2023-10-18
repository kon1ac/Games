using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("Выберите программу:");
                Console.WriteLine("1. Игра \"Угадай число\"");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("0. Выйти");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PlayGuessNumber();
                        break;
                    case 2:
                        PrintMultiplicationTable();
                        break;
                    case 3:
                        PrintDivisors();
                        break;
                    case 0:
                        Console.WriteLine("Выход из программы");
                        break;
                    default:
                        Console.WriteLine("Неверный ввод, пробуй снова");
                        break;
                }

            } while (choice != 0);
        }

        public static void PlayGuessNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 101);
            int guess;

            Console.WriteLine("Игра \"В гостях у ПИлы\" начинается!");
            do
            {
                Console.Write("Введите число: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomNumber)
                {
                    Console.WriteLine("Поздравляю, ты не умер!");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Моё число больше, чем ты думаешь");
                }
                else
                {
                    Console.WriteLine("Моё число меньше, чем ты думаешь");
                }
            } while (guess != randomNumber);
        }

        public static void PrintMultiplicationTable()
        {
            int size = 10;
            int[,] multiplicationTable = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                }
            }

            Console.WriteLine("Таблица умножения:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(multiplicationTable[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void PrintDivisors()
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Делители числа " + number + ":");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
