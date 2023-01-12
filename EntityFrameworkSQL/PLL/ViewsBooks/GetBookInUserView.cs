using EntityFrameworkSQL.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    internal class GetBookInUserView
    {
        BookRepository bookRepository;

        public void Show()
        {
            Console.Clear();
            bookRepository = new BookRepository();

            Console.WriteLine("Введите название книги");

            var istrue = bookRepository.GetBookInUser(Console.ReadLine());

            Console.WriteLine($"Наличие данной книги у пользователей на руках: {istrue}");
            Console.WriteLine();
        }
    }
}