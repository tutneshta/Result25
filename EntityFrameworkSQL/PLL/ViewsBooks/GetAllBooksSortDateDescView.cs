using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSQL.BLL;
using EntityFrameworkSQL.DAL.Repositories;

namespace EntityFrameworkSQL.PLL.ViewsBooks
{
    internal class GetAllBooksSortDateDescView
    {
        BookRepository bookRepository;

        public void Show()
        {
            Console.Clear();

            bookRepository = new BookRepository();

            ShowConsoleBooks.Show(bookRepository.GetAllBooksSortDateDesc());

            Console.WriteLine();
        }
    }
}