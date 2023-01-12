using EntityFrameworkSQL.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    internal class CountBooksAuthorView
    {
        BookRepository bookRepository;

        public void Show()
        {
            Console.Clear();
            bookRepository = new BookRepository();

            Console.WriteLine("Введите автора книги");

            var count = bookRepository.CountBooksAuthor(Console.ReadLine());

            Console.WriteLine($"Количество книг данного автора: {count}");
            Console.WriteLine();
        }
    }
}