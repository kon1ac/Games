
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;

namespace Games;
class Games
{
    static void num_detect()
    {

        Console.WriteLine("Введите число, что бы узнать, на что оно делится");
        Console.Write("Вводи циферку, друг:");

        int num = Convert.ToInt16(Console.ReadLine());
        for (int numer = 1; numer <= num; numer++)
        {
            if (num % numer == 0)
            {
                Console.Write(numer + "\t");
            }
        }
        Console.WriteLine();
    }



    static void Games_num()
    {
        // Написание игры угадай число отдельный файл как заготовка для полноценного проекта 





        Console.WriteLine("Добро пожаловать в игру 'В гостях у Пилы'");
        Console.WriteLine("Вы должны угадать число от 0 до 100");

        Random VALUE = new Random();
        int num = VALUE.Next(0, 100);
        


        try
        {

            while (true)
            {
                Console.Write("Вводи свою мысль, дорогой друг: "); string command = Console.ReadLine();

                int com_ = Convert.ToInt16(command);
               
                


                    if (com_ == num)
                    {
                        Console.WriteLine("Джекпот, друг, ты выиграл миллион!");
                        break;
                    }
                    else if (num < com_)
                    {
                        Console.WriteLine("Не угадал, делай меньше!");
                        
                        continue;
                    }
                    else if (num > com_)
                    {
                        Console.WriteLine("Не угадал, делай больше");
                        
                        continue;
                    }
                
                
            }
        }
        catch
        {
            Console.WriteLine("Ошибка, друг, твое значение неправильное");
        }


    }




    static void Tabl_um()
    {
        string[,] tabl = new string[10, 10];
        for (int row = 0; row <= 10; row++)
        {
            for (int column = 0; column <= 10; column++)
            {
                Console.Write((column + "*" + row + "=" + (column * row)) + "\t");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Boolean flag = true;
        while (flag)

        {
            Console.WriteLine();
            Console.WriteLine("Ты в главном меню, выбирай режим!");
            Console.WriteLine("1. Игра угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход");
            Console.Write("Вводи режим: ");
            try
            {
                string command = Console.ReadLine();
                int com_ = Convert.ToInt16(command);
                switch (com_)
                {
                    case 1:

                        Games_num();
                        break;
                    case 2:
                        Tabl_um();
                        break;
                    case 3:
                        num_detect();
                        break;
                    case 4:
                        flag = false;
                        break;
                }

            }
            catch
            {
                Console.WriteLine("Ты что-та сделал не правильно");
            }
        }
    }

}