using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    public class NextPageView
    {
        public void Show()
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine(
                    "Получить список книг определенного жанра и вышедших между определенными годами введите                          1");

                Console.WriteLine(
                    "Получать количество книг определенного автора в библиотеке введите                                              2");

                Console.WriteLine(
                    "Получить количество книг определенного жанра в библиотеке введите                                               3");

                Console.WriteLine(
                    "Получить булевый флаг о том, есть ли книга определенного автора и с определенным названием в библиотеке введите 4");

                Console.WriteLine(
                    "Получить булевый флаг о том, есть ли определенная книга на руках у пользователя введите                         5");

                Console.WriteLine(
                    "Получить количество книг на руках у пользователя введите                                                        6");

                Console.WriteLine(
                    "Получение последней вышедшей книги введите                                                                      7");

                Console.WriteLine(
                    "Получение списка всех книг, отсортированного в алфавитном порядке по названию введите                           8");

                Console.WriteLine(
                    "Получение списка всех книг, отсортированного в порядке убывания года их выхода введите                          9");

                Console.WriteLine();
                Console.WriteLine("Вернуться назад введите         10");
                Console.WriteLine("Вернуться в главное меню введите   11");


                var keyValue = Console.ReadLine();

                switch (keyValue)
                {
                    case "1":
                    {
                        Program.SelectBookGenreAndDate?.Show();
                        break;
                    }
                    case "2":
                    {
                        Program.CountBooksAuthor?.Show();
                        break;
                    }
                    case "3":
                    {
                        Program.CountBooksGenre?.Show();
                        break;
                    }
                    case "4":
                    {
                        Program.GetBookTitleAndAuthor?.Show();
                        break;
                    }
                    case "5":
                    {
                        Program.GetBookInUser?.Show();
                        break;
                    }
                    case "6":
                    {
                        Program.CountBookInUser?.Show();
                        break;
                    }
                    case "7":
                    {
                        Program.GetLastBook?.Show();
                        break;
                    }
                    case "8":
                    {
                        Program.GetAllBooksSortTitle?.Show();
                        break;
                    }
                    case "9":
                    {
                        Program.GetAllBooksSortDateDesc?.Show();
                        break;
                    }
                    case "10":
                    {
                        Program.BookView?.Show();
                        break;
                    }
                    case "11":
                    {
                        Program.MainView?.Show();
                        break;
                    }
                }
            }
        }
    }
}