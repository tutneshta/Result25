using EntityFrameworkSQL.DAL.Repositories;
using EntityFrameworkSQL.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    internal class CountBooksGenreView
    {
        BookRepository bookRepository;

        public void Show()
        {
            Console.Clear();
            bookRepository = new BookRepository();

            Console.WriteLine("Введите жанр книги");

            var count = bookRepository.CountBooksGenre(Console.ReadLine());

            Console.WriteLine($"Количество книг данного жанра: {count}");
            Console.WriteLine();
        }
    }
}