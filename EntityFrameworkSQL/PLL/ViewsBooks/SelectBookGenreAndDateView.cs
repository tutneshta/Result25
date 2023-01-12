using EntityFrameworkSQL.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    internal class SelectBookGenreAndDateView
    {
        BookRepository bookRepository;

        public void Show()
        {
            Console.Clear();
            bookRepository = new BookRepository();

            Console.WriteLine("Введите жанр книги");
            var genre = Console.ReadLine();

            Console.WriteLine("Введите начальную дату");
            var date1 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Введите конечную дату");
            var date2 = Convert.ToDateTime(Console.ReadLine());

            var books = bookRepository.SelectBookGenreAndDate(genre, date1, date2);

            ShowConsoleBooks.Show(books);
            Console.WriteLine();
        }
    }
}