using EntityFrameworkSQL.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    internal class GetBookTitleAndAuthorView
    {
        BookRepository bookRepository;

        public void Show()
        {
            Console.Clear();
            bookRepository = new BookRepository();

            Console.WriteLine("Введите автора книги");
            var author = Console.ReadLine();

            Console.WriteLine("Введите название книги");
            var title = Console.ReadLine();

            var isTrue = author != null && title != null && bookRepository.GetBookTitleAndAuthor(title, author);

            Console.WriteLine($"наличие книги: {isTrue}");
            Console.WriteLine();
        }
    }
}