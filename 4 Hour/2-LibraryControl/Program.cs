using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LibraryControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,] books = {
                { "Александр Пушкин", "Михаил Лермонтов", "Сергей Есенин" },
                { "Роберт Мартин", "Джесси Шелл", "Сергей Тепляков" },
                { "Стивен Кинг", "Говард Лавкрафт", "Ерем Стокер" }
            };

            while (isOpen) {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Здесь список авторов:\n");
                for (int i = 0; i < books.GetLength(0); i++) {
                    for (int j = 0; j < books.GetLength(1); j++) {
                        Console.Write(books[i, j] + " | ");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("1 - узнать имя автора по индексу книги. " +
                    "\n\n2 - найти книгу по автору. \n\n3 - выход.");
                Console.Write("\nВыберите пункт меню: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, column;
                        Console.Write("Введите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите номер столбца: ");
                        column = Convert.ToInt32(Console.ReadLine());
                        if (line > books.GetLength(0) || line <= 0) {
                            Console.WriteLine("Такой полки не существует.");
                        } else if (column > books.GetLength(1) || column <= 0) {
                            Console.WriteLine("Такого столбца не существует.");
                        } else {
                            Console.WriteLine("Это автор: " + books[--line, --column]);
                        }
                        break; 
                    case 2:
                        string author;
                        bool authorIsFound = false;
                        Console.Write("Введите автора: ");
                        author = Console.ReadLine();
                        for(int i = 0; i < books.GetLength(0); i++) {
                            for(int j = 0; j < books.GetLength(1); j++) {
                                if (books[i, j].ToLower() == author.ToLower()) {
                                    Console.Write($"Автор {books[i, j]} находится " +
                                        $"по адресу полка {i + 1}, место {j + 1}.");
                                    authorIsFound = true;
                                }
                            }
                        }
                        if (!authorIsFound) {
                            Console.WriteLine("Такого автора нет.");
                        }
                        break; 
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда.");
                        break;
                }

                if (isOpen) {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения.");
                } else  {
                    Console.WriteLine("\nНажмите любую клавишу для закрытия приложения.");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
