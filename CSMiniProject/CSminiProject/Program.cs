using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSminiProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Персонаж
            int age;
            string name;
            int hp;

            // Рандом
            Random rand = new Random();

            // Варианты
            int choice1;
            int choice2;

            // Игра с врагом
            int playerMoney = rand.Next(1, 100);
            int enemyMoney = rand.Next(1, 100);

            while (true)
            {
                Console.SetCursorPosition(0, 3);
                Console.ForegroundColor = ConsoleColor.White;

                // Возраст
                Console.Write("Введите ваш возраст: ");
                age = Convert.ToInt32(Console.ReadLine());

                // Имя
                Console.Write("Введите ваше имя: ");
                name = Console.ReadLine();

                // HP
                Console.Write("Сколько у вас HP: ");
                hp = Convert.ToInt32(Console.ReadLine());

                // Проверка Возраста и хп
                if (age > 100 || hp > 100)  
                {
                    Console.WriteLine("");
                    // Красный цвет
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("error 404 проверьте чтобы возраст и хп не превышали 100.\nПопробуй ещё раз.\n");
                }

                // Если нормальный человек то сюда
                else
                {
                    // Ваше имя
                    Console.WriteLine("");
                    Console.WriteLine("Информация о ввёденых данных");
                    Console.WriteLine($"Ваш возраст: {age} лет\nИмя: {name}\nHP: {hp}");

                    // Сюжетка
                    Console.WriteLine("");
                    // Красный цвет
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Таинственный голос: Вы находитесь в шахте вильямс\nПеред вами большое чудовище называемое Стрит чеир!");
                    // Белый цвет
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{name}, что будете делать?\n1.Убежать\n2.Попробовать атаковать");
                    Console.Write("Ваш ответ: ");
                    choice1 = Convert.ToInt32(Console.ReadLine());

                    // Выбор 1-ого варианта Убежать от чудовища
                    if (choice1 == 1)
                    {
                        Console.WriteLine("");
                        // Белый цвет
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Вы убежали в страхе от этого чудовища." +
                            $"\n{name}: Ухх устал!");
                        // Красный цвет
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Таинственный голос: На вашем пути встетрилось новое чудовище!" +
                            $"\nЧудовище: Давай сыграем в игру мешочек монет");
                        // Белый цвет
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"{name} сыграешь с противником?\n1.Сыграть\n2.Не играть идти дальше!");
                        Console.Write("Ваш ответ: ");
                        choice2 = Convert.ToInt32(Console.ReadLine());

                        // Выбор сыграть с чудовищем
                        if (choice2 == 1)
                        {
                            // Белый цвет
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("");
                            Console.WriteLine("Правила игры у кого больше монет тот и выиграл!");
                            Console.WriteLine("");
                            // Жёлтый цвет
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"У вас {playerMoney} монет.");
                            Console.WriteLine($"У врага {enemyMoney} монет.");

                            if (playerMoney < enemyMoney)
                            {
                                Console.WriteLine("");
                                // Красный цвет
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"{name} проиграл.");
                                Console.WriteLine($"{name} убит чудовищем!");
                                break;
                            }

                            else if (playerMoney > enemyMoney)
                            {
                                Console.WriteLine("");
                                // Белый цвет
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine($"{name} одержал победу.");
                                Console.WriteLine("Продолжение истории следует...");
                                break;
                            }

                            else
                            {
                                Console.WriteLine("");
                                // Белый цвет
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Ничья.");
                                Console.WriteLine("Продолжение истории следует...");
                                break;
                            }
                        }

                        else if (choice1 == 2)
                        {
                            Console.WriteLine("");
                            // Красный цвет
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Злодей безжалостно растоптал {name}.");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("");
                            // Красный цвет
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("error 462 Вы написали не 1 или 2");
                            Console.WriteLine($"{name} погиб\n");
                            break;
                        }
                    }

                    // Выбор 2-ого варианта Попробовать атаковать
                    else if (choice1 == 2)
                    {
                        Console.WriteLine("");
                        // Красный цвет
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{name} был убит чудовищем!");
                        break;
                    }

                    // Иной случай
                    else
                    {
                        Console.WriteLine("");
                        // Красный цвет
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы не написали 1 или 2 за это вам придётся начать с начала (");
                        Console.WriteLine($"{name} погиб");
                        break;
                    }
                }
            }
        }
    }
}
