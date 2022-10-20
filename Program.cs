using System;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>Угадай число<<<");
            Console.WriteLine("Будем играть в диапазоне от 0 до...");

            int range = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int randomN = rnd.Next(0, range+1);
            string playerN;

            Console.WriteLine("Поехали!");
            while (true)
            {
                Console.WriteLine("Введите число:");

                playerN = Console.ReadLine();

                if (playerN == "")                                                          //Если введена пустая строка
                {
                    Console.WriteLine("Игра окончена.");
                    Console.WriteLine($"Загаданное число: {randomN,4}");
                    Console.ReadKey();
                    break;
                }

                else
                {
                    int playerNumber = int.Parse(playerN);

                    if (playerNumber < randomN)
                        Console.WriteLine("Загаданное число больше!");
                    else if (playerNumber > randomN)
                        Console.WriteLine("Загаданное число меньше!");
                    else
                    {
                        Console.WriteLine("Поздравляю! Вы победили");
                        Console.WriteLine($"Загаданное число: {randomN,4}");
                        Console.ReadKey();
                        break;
                    }
                }               
            }
        }
    }
}
