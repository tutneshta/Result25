using EntityFrameworkSQL.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    internal class GetLastBookView
    {
        BookRepository bookRepository;

        public void Show()
        {
            Console.Clear();
            bookRepository = new BookRepository();

            var book = bookRepository.GetLastBook();

            Console.WriteLine(
                $"Название книги: {book.Title}\nДата: {book.Date}\nАвтор: {book.Author}\n Жанр: {book.Genre} ");

            Console.WriteLine();
        }
    }
}