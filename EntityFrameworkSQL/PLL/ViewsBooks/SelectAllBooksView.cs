using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL;
using EntityFrameworkSQL.BLL.Models;
using EntityFrameworkSQL.DAL.Repositories;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    internal class SelectAllBooksView
    {
        public BookRepository BookRepository;

        public void Show()
        {
            Console.Clear();
            BookRepository = new BookRepository();

            Console.Clear();

            var books = BookRepository.SelectAllBooks();

            ShowConsoleBooks.Show(books);

            Console.WriteLine();
        }
    }
}