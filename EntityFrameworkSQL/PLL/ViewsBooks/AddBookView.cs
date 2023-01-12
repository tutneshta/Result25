using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.DAL.Repositories;
using EntityFrameworkSQL.PLL.Helpers;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    internal class AddBookView
    {
        public BookRepository bookRepository;


        public void Show()
        {
            Console.Clear();
            bookRepository = new BookRepository();

            Console.WriteLine("Введите название книги");
            string title = Console.ReadLine();

            Console.WriteLine("Введите дату");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Введите автора книги");
            string author = Console.ReadLine();

            Console.WriteLine("Введите жанр книги");
            string genre = Console.ReadLine();

            if (title != "")
            {
                bookRepository.AddBook(title, date, author, genre);

                Console.WriteLine($"Книга {title} добавлена");
                Console.WriteLine();
            }
            else
            {
                AlertMessage.Show("название не может быть пустым");
                Console.WriteLine();
            }
        }
    }
}