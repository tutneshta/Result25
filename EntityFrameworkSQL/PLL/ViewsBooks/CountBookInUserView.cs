using EntityFrameworkSQL.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    internal class CountBookInUserView
    {
        BookRepository bookRepository;

        public void Show()
        {
            Console.Clear();
            bookRepository = new BookRepository();

            Console.WriteLine("Введите id пользователя");

            var count = bookRepository.CountBookInUser(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine($"Количество книг у данного пользователя: {count}");
            Console.WriteLine();
        }
    }
}