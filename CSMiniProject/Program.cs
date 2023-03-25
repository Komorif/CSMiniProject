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
            // Для работы русского языка
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            // Данные о игроке
            int age; // Возраст
            string name; // Имя
            int hp; // hp

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
                Console.SetCursorPosition(0, 3);

                // Цвет текста (белый)
                Console.ForegroundColor = ConsoleColor.White;


                // Введите имя
                Console.Write("Введите ваше имя: ");
                name = Console.ReadLine();


                // Введите возраст
                Console.Write("Введите ваш возраст: ");
                age = Convert.ToInt32(Console.ReadLine());


                // Введите hp
                Console.Write("Сколько у вас HP: ");
                hp = Convert.ToInt32(Console.ReadLine());


                // Проверка возраста или hp (если больше 100 то error 404)
                if (age > 100 || hp > 100)
                {
                    Console.WriteLine("");

                    // Цвет текста (красный)
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("error 404\nпроверьте чтобы возраст или hp не превышал 100.\nПопробуй ещё раз.\n\n\n");
                }


                // Если нет ошибок (продолжение бродилки)
                else
                {
                    Console.WriteLine("");

                    // Информация о введён даных (Возраст, Имя, hp)
                    Console.WriteLine("Информация о ввёденых данных");
                    Console.WriteLine($"Ваш возраст: {age} лет\nИмя: {name}\nHP: {hp}");

                    Console.WriteLine("");


                    // Сюжет (начало)

                    // Цвет текста (красный)
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Таинственный голос: Вы находитесь в шахте вильямс\nПеред вами большое чудовище называемое Стрит чеир!");

                    // Цвет текста (белый)
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"{name}, что будете делать?\n1.Убежать\n2.Попробовать атаковать");
                    Console.Write("Ваш ответ: ");
                    choice1 = Convert.ToInt32(Console.ReadLine());

                    // Выбор (Убежать от чудовища)
                    if (choice1 == 1)
                    {
                        Console.WriteLine("");

                        // Цвет текста (белый)
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine($"Вы убежали в страхе от этого чудовища." +
                            $"\n{name}: Ухх устал!");

                        // Цвет текста (красный)
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Таинственный голос: На вашем пути встетрилось новое чудовище!" +
                            $"\nЧудовище: Давай сыграем в игру мешочек монет");

                        // Цвет текста (белый)
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine($"{name} сыграешь с противником?\n1.Сыграть\n2.Не играть идти дальше!");
                        Console.Write("Ваш ответ: ");
                        choice2 = Convert.ToInt32(Console.ReadLine());

                        // Выбор (сыграть с чудовищем)
                        if (choice2 == 1)
                        {
                            // Цвет текста (белый)
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("");

                            Console.WriteLine("Правила игры у кого больше монет тот и выиграл!");

                            Console.WriteLine("");

                            // Цвет текста (жёлтый)
                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.WriteLine($"У вас {playerMoney} монет.");
                            Console.WriteLine($"У врага {enemyMoney} монет.");

                            // Проверка монет (если у игрока монет меньше чудовища)
                            if (playerMoney < enemyMoney)
                            {
                                Console.WriteLine("");

                                // Цвет текста (красный)
                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.WriteLine($"{name} проиграл.");
                                Console.WriteLine($"{name} убит чудовищем!\n\n\n");
                                break;
                            }

                            // Проверка монет (если у игрока монет больше чудовища)
                            else if (playerMoney > enemyMoney)
                            {
                                Console.WriteLine("");
                                
                                // Цвет текста (белый)
                                Console.ForegroundColor = ConsoleColor.White;
                                
                                Console.WriteLine($"{name} одержал победу.");
                                Console.WriteLine("Продолжение истории следует...\n\n\n");
                                break;
                            }

                            // Проверка монет (при ином исходе)
                            else
                            {
                                Console.WriteLine("");

                                // Цвет текста (белый)
                                Console.ForegroundColor = ConsoleColor.White;
                                
                                Console.WriteLine("Ничья.");
                                Console.WriteLine("Продолжение истории следует...\n\n\n");
                                break;
                            }
                        }

                        // Выбор (попробовать атаковать)
                        else if (choice1 == 2)
                        {
                            Console.WriteLine("");
                            
                            // Цвет текста (красный)
                            Console.ForegroundColor = ConsoleColor.Red;
                            
                            Console.WriteLine($"Злодей безжалостно растоптал {name}.\n\n\n");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("");
                            
                            // Цвет текста (красный)
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("error 462 Вы написали не 1 или 2");
                            Console.WriteLine($"{name} погиб\n\n\n");
                            break;
                        }
                    }

                    // Выбор (Попробовать атаковать)
                    else if (choice1 == 2)
                    {
                        Console.WriteLine("");

                        // Цвет текста (красный)
                        Console.ForegroundColor = ConsoleColor.Red;
                        
                        Console.WriteLine($"{name} был убит чудовищем!\n\n\n");
                        break;
                    }

                    // Выбор (Не сыграть с чудовищем)
                    else
                    {
                        Console.WriteLine("");

                        // Цвет текста (красный)
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Вы не написали 1 или 2 за это вам придётся начать с начала (");
                        Console.WriteLine($"{name} погиб\n\n\n");
                        break;
                    }
                }
            }
        }
    }
}
