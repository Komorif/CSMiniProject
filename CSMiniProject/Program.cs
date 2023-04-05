using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSminiProject
{
    internal class Program
    {
        // Функция Main
        static void Main(string[] args)
        {
            // данные о игроке
            int age; // Возраст
            int hp; // hp
            string name; // Имя

            // Для работы русского языка
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Рандом
            Random rand = new Random();

            // Варианты играть с чудовищем или нет
            int choice1; // Играть с чудовищем
            int choice2; // Не играть с чудовищем

            // Игра с врагом
            int playerMoney = rand.Next(1, 101); // Монеты игрока
            int enemyMoney = rand.Next(1, 101); // Монеты чудовища

            // Бесконечный цикл
            while (true)
            {

                // Пробел три строки
                Console.SetCursorPosition(0, 2);

                // Цвет текста (белый)
                Console.ForegroundColor = ConsoleColor.White;


                // Введите имя
                Console.Write("Введите ваше имя: ");
                name = Console.ReadLine();


                // Введите возраст
                Console.Write($"{name} введите ваш возраст: ");
                age = Convert.ToInt32(Console.ReadLine());


                // Введите hp
                Console.Write($"{name} сколько у вас HP: ");
                hp = Convert.ToInt32(Console.ReadLine());
;

                // Проверка возраста или hp (если больше 100 то error 404)
                if (age > 100 || hp > 100)
                {
                    // Вызов функции (Death)
                    Death();

                    // Вызоы функции (Time) (1секунда)
                    Time();

                    Console.WriteLine("error 404");

                    // Вызоы функции (Time) (1секунда)
                    Time();

                    Console.WriteLine("Проверьте чтобы возраст или hp не превышал 100");

                    // Вызоы функции (Time) (1секунда)
                    Time();

                    Console.WriteLine("Попробуй ещё раз.\n\n");
                }


                // Если нет ошибок (продолжение бродилки)
                else
                {
                    // Вызов функции (BlankLine)
                    BlankLine(); // Пустая строка

                    // Вызоы функции (Time) (1секунда)
                    Time();

                    // Информация о введён даных (Возраст, Имя, hp)
                    Console.WriteLine("Информация о ввёденых данных");
                    Console.WriteLine($"Ваше имя: {name}\nВам: {age} лет\nHP: {hp}");

                    // Вызов функции (BlankLine)
                    BlankLine(); // Пустая строка


                    // Сюжет (начало)

                    // Цвет текста (красный)
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Вызоы функции (Time) (1секунда)
                    Time();

                    Console.WriteLine("Таинственный голос: Вы находитесь в шахте вильямс\nПеред вами большое чудовище называемое Стрит чеир!");

                    // Цвет текста (белый)
                    Console.ForegroundColor = ConsoleColor.White;

                    // Вызоы функции (Time) (1секунда)
                    Time();

                    Console.WriteLine($"{name}, что будете делать?\n1.Убежать\n2.Попробовать атаковать");
                    Console.Write("Ваш ответ: ");
                    choice1 = Convert.ToInt32(Console.ReadLine());

                    // Выбор (Убежать от чудовища)
                    if (choice1 == 1)
                    {
                        // Вызов функции (BlankLine)
                        BlankLine(); // Пустая строка

                        // Цвет текста (белый)
                        Console.ForegroundColor = ConsoleColor.White;

                        // Вызоы функции (Time) (1секунда)
                        Time();

                        Console.WriteLine($"Вы убежали в страхе от этого чудовища." +
                            $"\n{name}: Ухх устал!");

                        // Цвет текста (красный)
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Вызоы функции (Time) (1секунда)
                        Time();

                        Console.WriteLine("Таинственный голос: На вашем пути встетрилось новое чудовище!" +
                            $"\nЧудовище: Давай сыграем в игру мешочек монет");

                        // Цвет текста (белый)
                        Console.ForegroundColor = ConsoleColor.White;

                        // Вызоы функции (Time) (1секунда)
                        Time();

                        Console.WriteLine($"{name} сыграешь с противником?\n1.Сыграть\n2.Не играть идти дальше!");

                        // Вызоы функции (Time) (1секунда)
                        Time();

                        Console.Write("Ваш ответ: ");
                        choice2 = Convert.ToInt32(Console.ReadLine());

                        // Выбор (сыграть с чудовищем)
                        if (choice2 == 1)
                        {
                            // Цвет текста (белый)
                            Console.ForegroundColor = ConsoleColor.White;

                            // Вызов функции (BlankLine)
                            BlankLine(); // Пустая строка

                            // Вызоы функции (Time) (1секунда)
                            Time();

                            Console.WriteLine("Правила игры у кого больше монет тот и выиграл!");

                            // Вызов функции (BlankLine)
                            BlankLine(); // Пустая строка

                            // Цвет текста (жёлтый)
                            Console.ForegroundColor = ConsoleColor.Yellow;

                            // Вызоы функции (Time) (1секунда)
                            Time();

                            Console.WriteLine($"У вас {playerMoney} монет.");

                            // Вызоы функции (Time) (1секунда)
                            Time();

                            Console.WriteLine($"У врага {enemyMoney} монет.");

                            // Проверка монет (если у игрока монет меньше чудовища)
                            if (playerMoney < enemyMoney)
                            {
                                // Вызоы функции (Time) (1секунда)
                                Time();

                                // Вызов функции (Death)
                                Death();

                                // Конец
                                break;
                            }

                            // Проверка монет (если у игрока монет больше чудовища)
                            else if (playerMoney > enemyMoney)
                            {
                                // Вызов функции (BlankLine)
                                BlankLine(); // Пустая строка

                                // Цвет текста (белый)
                                Console.ForegroundColor = ConsoleColor.White;

                                // Вызоы функции (Time) (1секунда)
                                Time();

                                Console.WriteLine($"{name} одержал(а) победу.");

                                // Вызоы функции (Time) (1секунда)
                                Time();

                                Console.WriteLine("Продолжение истории следует...\n\n");

                                // Конец
                                break;
                            }

                            // Проверка монет (при ином исходе)
                            else
                            {
                                // Вызов функции (BlankLine)
                                BlankLine(); // Пустая строка

                                // Цвет текста (белый)
                                Console.ForegroundColor = ConsoleColor.White;

                                // Вызоы функции (Time) (1секунда)
                                Time();

                                Console.WriteLine("Ничья.");

                                // Вызоы функции (Time) (1секунда)
                                Time();

                                Console.WriteLine("Продолжение истории следует...\n\n");

                                // Конец
                                break;
                            }
                        }

                        // Выбор (попробовать атаковать)
                        else if (choice1 == 2)
                        {
                            // Вызоы функции (Time) (1секунда)
                            Time();

                            // Вызов функции (Death)
                            Death();

                            // Конец
                            break;
                        }

                        else
                        {
                            // Вызоы функции (Time) (1секунда)
                            Time();

                            // Вызов функции (Death)
                            Death();

                            // Вызоы функции (Time) (1секунда)
                            Time();

                            Console.WriteLine("error 462 Вы написали не 1 или 2\n\n");

                            // Конец
                            break;
                        }
                    }

                    // Выбор (Попробовать атаковать)
                    else if (choice1 == 2)
                    {
                        // Вызоы функции (Time) (1секунда)
                        Time();

                        // Вызов функции (Death)
                        Death();

                        // Конец
                        break;
                    }

                    // Выбор (Не сыграть с чудовищем)
                    else
                    {
                        // Вызоы функции (Time) (1секунда)
                        Time();

                        // Вызов функции (Death)
                        Death();

                        // Вызоы функции (Time) (1секунда)
                        Time();

                        Console.WriteLine("Вы не написали 1 или 2 за это вам придётся начать с начала (\n\n");

                        // Конец
                        break;
                    }
                }
            }
        }


        // Функция (Погиб)
        static void Death()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nВы погибли\n\n");
        }

        // Функция (Пустая строка)        
        static void BlankLine()
        {
            Console.WriteLine("");
        }

        // Функция (Time)
        static void Time()
        {
            Thread.Sleep(1000);
        }

    }
}
